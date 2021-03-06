// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Group.
    /// </summary>
    [DataContract]
    public partial class Group : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false, IsRequired = false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false, IsRequired = false)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets group types.
        /// </summary>
        [DataMember(Name = "groupTypes", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> GroupTypes { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// </summary>
        [DataMember(Name = "mail", EmitDefaultValue = false, IsRequired = false)]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail enabled.
        /// </summary>
        [DataMember(Name = "mailEnabled", EmitDefaultValue = false, IsRequired = false)]
        public bool? MailEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// </summary>
        [DataMember(Name = "mailNickname", EmitDefaultValue = false, IsRequired = false)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// </summary>
        [DataMember(Name = "onPremisesLastSyncDateTime", EmitDefaultValue = false, IsRequired = false)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// </summary>
        [DataMember(Name = "onPremisesSecurityIdentifier", EmitDefaultValue = false, IsRequired = false)]
        public string OnPremisesSecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// </summary>
        [DataMember(Name = "onPremisesSyncEnabled", EmitDefaultValue = false, IsRequired = false)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// </summary>
        [DataMember(Name = "proxyAddresses", EmitDefaultValue = false, IsRequired = false)]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets security enabled.
        /// </summary>
        [DataMember(Name = "securityEnabled", EmitDefaultValue = false, IsRequired = false)]
        public bool? SecurityEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false, IsRequired = false)]
        public string Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets allow external senders.
        /// </summary>
        [DataMember(Name = "allowExternalSenders", EmitDefaultValue = false, IsRequired = false)]
        public bool? AllowExternalSenders { get; set; }
    
        /// <summary>
        /// Gets or sets auto subscribe new members.
        /// </summary>
        [DataMember(Name = "autoSubscribeNewMembers", EmitDefaultValue = false, IsRequired = false)]
        public bool? AutoSubscribeNewMembers { get; set; }
    
        /// <summary>
        /// Gets or sets is subscribed by mail.
        /// </summary>
        [DataMember(Name = "isSubscribedByMail", EmitDefaultValue = false, IsRequired = false)]
        public bool? IsSubscribedByMail { get; set; }
    
        /// <summary>
        /// Gets or sets unseen count.
        /// </summary>
        [DataMember(Name = "unseenCount", EmitDefaultValue = false, IsRequired = false)]
        public Int32? UnseenCount { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = false, IsRequired = false)]
        public IGroupMembersCollectionWithReferencesPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// </summary>
        [DataMember(Name = "memberOf", EmitDefaultValue = false, IsRequired = false)]
        public IGroupMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets created on behalf of.
        /// </summary>
        [DataMember(Name = "createdOnBehalfOf", EmitDefaultValue = false, IsRequired = false)]
        public DirectoryObject CreatedOnBehalfOf { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// </summary>
        [DataMember(Name = "owners", EmitDefaultValue = false, IsRequired = false)]
        public IGroupOwnersCollectionWithReferencesPage Owners { get; set; }
    
        /// <summary>
        /// Gets or sets threads.
        /// </summary>
        [DataMember(Name = "threads", EmitDefaultValue = false, IsRequired = false)]
        public IGroupThreadsCollectionPage Threads { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// </summary>
        [DataMember(Name = "calendar", EmitDefaultValue = false, IsRequired = false)]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// </summary>
        [DataMember(Name = "calendarView", EmitDefaultValue = false, IsRequired = false)]
        public IGroupCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false, IsRequired = false)]
        public IGroupEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets conversations.
        /// </summary>
        [DataMember(Name = "conversations", EmitDefaultValue = false, IsRequired = false)]
        public IGroupConversationsCollectionPage Conversations { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// </summary>
        [DataMember(Name = "photo", EmitDefaultValue = false, IsRequired = false)]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets accepted senders.
        /// </summary>
        [DataMember(Name = "acceptedSenders", EmitDefaultValue = false, IsRequired = false)]
        public IGroupAcceptedSendersCollectionPage AcceptedSenders { get; set; }
    
        /// <summary>
        /// Gets or sets rejected senders.
        /// </summary>
        [DataMember(Name = "rejectedSenders", EmitDefaultValue = false, IsRequired = false)]
        public IGroupRejectedSendersCollectionPage RejectedSenders { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// </summary>
        [DataMember(Name = "drive", EmitDefaultValue = false, IsRequired = false)]
        public Drive Drive { get; set; }
    
    }
}

