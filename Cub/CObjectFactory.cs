﻿using Newtonsoft.Json.Linq;

namespace Cub
{
    public class CObjectFactory
    {
        public static CObject FromJObject(JObject obj)
        {
            if (obj?["object"] == null || obj["id"] == null)
                return null;
            var objType = obj["object"].Value<string>();
            switch (objType)
            {
                case "user":
                    var user = new User();
                    user.FromObject(obj);
                    return user;
                case "subscription":
                    var subscription = new Subscription();
                    subscription.FromObject(obj);
                    return subscription;
                case "mailinglist":
                    var mailingList = new MailingList();
                    mailingList.FromObject(obj);
                    return mailingList;
                case "lead":
                    var lead = new Lead();
                    lead.FromObject(obj);
                    return lead;
                case "organization":
                    var organization = new Organization();
                    organization.FromObject(obj);
                    return organization;
            }

            return null;
        }
    }
}
