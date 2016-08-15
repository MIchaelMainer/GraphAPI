using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace Microsoft.Graph.Test.Requests.Generated
{
    //internal static class AuthenticationHelper
    //{
    //    // The Client ID is used by the application to uniquely identify itself to Microsoft Azure Active Directory (AD).
    //    static string clientId = App.Current.Resources["ida:ClientID"].ToString();
    //    static string returnUrl = App.Current.Resources["ida:ReturnUrl"].ToString();


    //    public static PublicClientApplication IdentityClientApp = null;
    //    public static string TokenForUser = null;
    //    public static DateTimeOffset expiration;

    //    private static GraphServiceClient graphClient = null;

    //    // Get an access token for the given context and resourceId. An attempt is first made to 
    //    // acquire the token silently. If that fails, then we try to acquire the token by prompting the user.
    //    public static GraphServiceClient GetAuthenticatedClient()
    //    {
    //        if (graphClient == null)
    //        {
    //            // Create Microsoft Graph client.
    //            try
    //            {
    //                graphClient = new GraphServiceClient(
    //                    "https://graph.microsoft.com/stagingv1.0",
    //                    new DelegateAuthenticationProvider(
    //                        async (requestMessage) =>
    //                        {
    //                            var token = await GetTokenForUserAsync();
    //                            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);

    //                        }));
    //                return graphClient;
    //            }

    //            catch (Exception ex)
    //            {
    //                Debug.WriteLine("Could not create a graph client: " + ex.Message);
    //            }
    //        }

    //        return graphClient;
    //    }


    //    /// <summary>
    //    /// Get Token for User.
    //    /// </summary>
    //    /// <returns>Token for user.</returns>
    //    public static async Task<string> GetTokenForUserAsync()
    //    {
    //        if (TokenForUser == null || expiration <= DateTimeOffset.UtcNow.AddMinutes(5))
    //        {
    //            var redirectUri = new Uri(returnUrl);
    //            var scopes = new string[]
    //                    {
    //                    "https://graph.microsoft.com/User.Read",
    //                    "https://graph.microsoft.com/User.ReadWrite",
    //                    "https://graph.microsoft.com/User.ReadBasic.All",
    //                    "https://graph.microsoft.com/Mail.Send",
    //                    "https://graph.microsoft.com/Calendars.ReadWrite",
    //                    "https://graph.microsoft.com/Mail.ReadWrite",
    //                    "https://graph.microsoft.com/Files.ReadWrite",
    //                    "https://graph.microsoft.com/MailboxSettings.ReadWrite"

    //                    // Admin-only scopes. Uncomment these if you're running the sample with an admin work account.
    //                    // You won't be able to sign in with a non-admin work account if you request these scopes.
    //                    // These scopes will be ignored if you leave them uncommented and run the sample with a consumer account.
    //                    // See the MainPage.xaml.cs file for all of the operations that won't work if you're not running the 
    //                    // sample with an admin work account.
    //                    //"https://graph.microsoft.com/Directory.AccessAsUser.All",
    //                    //"https://graph.microsoft.com/User.ReadWrite.All",
    //                    //"https://graph.microsoft.com/Group.ReadWrite.All"


    //                };

    //            IdentityClientApp = new PublicClientApplication(clientId);
    //            AuthenticationResult authResult = await IdentityClientApp.AcquireTokenAsync(scopes);

    //            TokenForUser = authResult.Token;
    //            expiration = authResult.ExpiresOn;
    //        }

    //        return TokenForUser;
    //    }


    //    /// <summary>
    //    /// Signs the user out of the service.
    //    /// </summary>
    //    public static void SignOut()
    //    {
    //        foreach (var user in IdentityClientApp.Users)
    //        {
    //            user.SignOut();
    //        }
    //        graphClient = null;
    //        TokenForUser = null;

    //    }


    //}



    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            //var excelWorkbookId = "012KW42LDENXUUPCMYQJDYX3CLZMORQKGT";
            //var excelWorksheetId = "Sheet1";
            //var rangeAddress = "A1";
            //WorkbookRange rangeToUpdate;

            //// admin@MOD182601.onmicrosoft.com 

     
            //    var graphClient = AuthenticationHelper.GetAuthenticatedClient();

            //    // https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/
            //    //var downloadedFile = await graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Request().GetAsync();

            //    // GET https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/UsedRange
            //    // GET https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/Range

            //    // GET https://graph.microsoft.com/beta/me/drive/items('012KW42LDENXUUPCMYQJDYX3CLZMORQKGT')/workbook/worksheets('Sheet1')/Range(address='A1')
            //    //graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Request().GetAsync();


            //    var rangeRequest = graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Request();
            //    rangeToUpdate = await rangeRequest.GetAsync();


            //    //rangeToUpdate.Values = "[[ 3.14 ]]";
            //    //var dummyWorkbookRange = new WorkbookRange();
            //    //dummyWorkbookRange.Values = "[[ 3.14 ]]";
            //    //graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Set(dummyWorkbookRange).Request().PostAsync();

            //    //rangeToUpdate.Values=

            //    // Forming the JSON
            //    var arr = rangeToUpdate.Values as JArray;
            //    var arrInner = arr[0] as JArray;
            //    arrInner[0] = $"{arrInner[0] + "C"}"; // JToken


            //    var dummyWorkbookRange = new WorkbookRange();
            //    dummyWorkbookRange.Values = arr;

            //    var workbookRange = await graphClient.Me.Drive.Items[excelWorkbookId].Workbook.Worksheets[excelWorksheetId].Range(rangeAddress).Request().UpdateAsync(dummyWorkbookRange);

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


            Assert.Fail();

        }
    }
}
