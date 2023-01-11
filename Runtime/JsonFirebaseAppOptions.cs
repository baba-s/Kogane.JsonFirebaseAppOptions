using System;
using Firebase;
using UnityEngine;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace Kogane
{
    [Serializable]
    public struct JsonFirebaseAppOptions
    {
        [SerializeField] private string databaseUrl;
        [SerializeField] private string appId;
        [SerializeField] private string apiKey;
        [SerializeField] private string messageSenderId;
        [SerializeField] private string storageBucket;
        [SerializeField] private string projectId;

        public JsonFirebaseAppOptions( AppOptions options )
        {
            databaseUrl     = options.DatabaseUrl?.ToString();
            appId           = options.AppId;
            apiKey          = options.ApiKey;
            messageSenderId = options.MessageSenderId;
            storageBucket   = options.StorageBucket;
            projectId       = options.ProjectId;
        }

        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}