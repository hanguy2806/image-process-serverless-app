using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace TempProject
{
    [DynamoDBTable("Photo")]
    public class Photo
    {
        [DynamoDBHashKey]
        public string PhotoId { get; set; }
        [DynamoDBProperty]
        public Dictionary<string, float> Tags { get; set; }

        public Photo() { }

        public Photo(string id, Dictionary<string, float> tags)
        {
            this.PhotoId = id;
            this.Tags = tags;
        }
    }
}
