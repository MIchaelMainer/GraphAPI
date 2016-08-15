using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using Microsoft.Identity.Client;
using Microsoft.Graph;
using Newtonsoft.Json.Linq;

namespace Microsoft.Graph.Test.Requests.Generated
{
    internal static class AuthenticationHelper
    {
        // The Client ID is used by the application to uniquely identify itself to Microsoft Azure Active Directory (AD).
        static string clientId = "fd578178-e9da-4af3-a2e2-35ce5c90f803";
        static string returnUrl = "urn:ietf:wg:oauth:2.0:oob";


        public static PublicClientApplication IdentityClientApp = null;
        public static string TokenForUser = null;
        public static DateTimeOffset expiration;

        private static GraphServiceClient graphClient = null;

        // Get an access token for the given context and resourceId. An attempt is first made to 
        // acquire the token silently. If that fails, then we try to acquire the token by prompting the user.
        public static GraphServiceClient GetAuthenticatedClient()
        {
            if (graphClient == null)
            {
                // Create Microsoft Graph client.
                try
                {
                    graphClient = new GraphServiceClient(
                        "https://graph.microsoft.com/stagingv1.0",
                        new DelegateAuthenticationProvider(
                            async (requestMessage) =>
                            {
                                //var token = await GetTokenForUserAsync();
                                var token = await getAccessTokenUsingPasswordGrant();
                                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);

                            }));
                    return graphClient;
                }

                catch (Exception ex)
                {
                    //Debug.WriteLine("Could not create a graph client: " + ex.Message);
                }
            }

            return graphClient;
        }


        /// <summary>
        /// Get Token for User.
        /// </summary>
        /// <returns>Token for user.</returns>
        public static async Task<string> GetTokenForUserAsync()
        {
            if (TokenForUser == null || expiration <= DateTimeOffset.UtcNow.AddMinutes(5))
            {
                var redirectUri = new Uri(returnUrl);
                var scopes = new string[]
                        {
                            "https://graph.microsoft.com/User.Read",
                            "https://graph.microsoft.com/User.ReadWrite",
                            "https://graph.microsoft.com/User.ReadBasic.All",
                            "https://graph.microsoft.com/Mail.Send",
                            "https://graph.microsoft.com/Calendars.ReadWrite",
                            "https://graph.microsoft.com/Mail.ReadWrite",
                            "https://graph.microsoft.com/Files.ReadWrite",
                            "https://graph.microsoft.com/MailboxSettings.ReadWrite"

                            // Admin-only scopes. Uncomment these if you're running the sample with an admin work account.
                            // You won't be able to sign in with a non-admin work account if you request these scopes.
                            // These scopes will be ignored if you leave them uncommented and run the sample with a consumer account.
                            // See the MainPage.xaml.cs file for all of the operations that won't work if you're not running the 
                            // sample with an admin work account.
                            //"https://graph.microsoft.com/Directory.AccessAsUser.All",
                            //"https://graph.microsoft.com/User.ReadWrite.All",
                            //"https://graph.microsoft.com/Group.ReadWrite.All"


                        };

                //var user = new Microsoft.Identity.Client.User();

                

                IdentityClientApp = new PublicClientApplication(clientId);
                AuthenticationResult authResult = await IdentityClientApp.AcquireTokenAsync(scopes);

                TokenForUser = authResult.Token;
                expiration = authResult.ExpiresOn;
            }

            return TokenForUser;
        }

        private static string AccessToken = null;
        private static string ClientId = System.Environment.GetEnvironmentVariable("test_client_id");
        private static string UserName = System.Environment.GetEnvironmentVariable("test_user_name");
        private static string Password = System.Environment.GetEnvironmentVariable("test_password");
        private static string ContentType = "application/x-www-form-urlencoded";
        private static string GrantType = "password";
        private static string TokenEndpoint = "https://login.microsoftonline.com/common/oauth2/token";
        private static string ResourceId = "https%3A%2F%2Fgraph.microsoft.com%2F";

        public static async Task<string> getAccessTokenUsingPasswordGrant()
        {
            JObject jResult = null;
            String urlParameters = String.Format(
                    "grant_type={0}&resource={1}&client_id={2}&username={3}&password={4}",
                    GrantType,
                    ResourceId,
                    ClientId,
                    UserName,
                    Password
            );

            HttpClient client = new HttpClient();
            var createBody = new StringContent(urlParameters, System.Text.Encoding.UTF8, ContentType);
            Task<HttpResponseMessage> requestTask = client.PostAsync(TokenEndpoint, createBody);
            requestTask.Wait();
            HttpResponseMessage response = requestTask.Result;

            if (response.IsSuccessStatusCode)
            {
                Task<string> responseTask = response.Content.ReadAsStringAsync();
                responseTask.Wait();
                string responseContent = responseTask.Result;
                jResult = JObject.Parse(responseContent);
            }
            AccessToken = (string)jResult["access_token"];

            if (!String.IsNullOrEmpty(AccessToken))
            {
                //Set AuthenticationHelper values so that the regular MSAL auth flow won't be triggered.
                AuthenticationHelper.TokenForUser = AccessToken;
                AuthenticationHelper.expiration = DateTimeOffset.UtcNow.AddHours(5);
            }

            return AccessToken;
            
        }


    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var excelWorkbookId = "012KW42LDENXUUPCMYQJDYX3CLZMORQKGT";
            var excelWorksheetId = "Sheet1";
            var rangeAddress = "A1";
            WorkbookRange rangeToUpdate;

            //// admin@MOD182601.onmicrosoft.com 


            var graphClient = AuthenticationHelper.GetAuthenticatedClient();

            //    // https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/
            //    //var downloadedFile = await graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Request().GetAsync();

            //    // GET https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/UsedRange
            //    // GET https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/Range

            //    // GET https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/Range(address='A1')
            //    //graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Request().GetAsync();


            var rangeRequest = graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Request();
            rangeToUpdate = await rangeRequest.GetAsync();


            //    //rangeToUpdate.Values = "[[ 3.14 ]]";
            //    //var dummyWorkbookRange = new WorkbookRange();
            //    //dummyWorkbookRange.Values = "[[ 3.14 ]]";
            //    //graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Set(dummyWorkbookRange).Request().PostAsync();


            // Forming the JSON
            var arr = rangeToUpdate.Values as JArray;
            var arrInner = arr[0] as JArray;
            arrInner[0] = $"{arrInner[0] + "C"}"; // JToken



            var dummyWorkbookRange = new WorkbookRange();
            dummyWorkbookRange.Values = arr;

            var workbookRange = await graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Request().UpdateAsync(dummyWorkbookRange);

            Assert.IsNotNull(workbookRange, "The value in the range is {0}", workbookRange.Values.ToString());

            //    // 'Manually' chain the request URL and send the PATCH request
            //    //var workbookRangeRequestBuilder = new WorkbookRangeRequestBuilder(rangeRequest.RequestUrl, graphClient);
            //    //var workbookRangeRequest = workbookRangeRequestBuilder.Request();
            //    //var workbookRangeOnServer = await workbookRangeRequest.UpdateAsync(dummyWorkbookRange);

            //    return true;

            // Check whether the value was set on server.
            //var arrServerValues = workbookRangeOnServer.Values as JArray;
            //var arrInnerServerValues = arrServerValues[0] as JArray;

            //if (arrInnerServerValues == arrInner)
            //{
            //    return true;
            //}
            //else {
            //    return false;
            //}


            // PATCH https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/Range(address='A1')
            // Body: {     "values": [ [ "Changed2HeaderA" ] ]  }
            //await workbookRangeRequest.UpdateAsync(rangeToUpdate);

        }
    }

}