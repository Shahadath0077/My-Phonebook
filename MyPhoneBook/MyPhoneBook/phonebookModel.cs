using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyPhoneBook
{
  
    public class phoneBookModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }
       
        public string Email { get; set; }
      
        public string PhoneNo { get; set; }

    }
}
