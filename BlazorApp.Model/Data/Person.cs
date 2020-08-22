using Shared.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shared.Model.Data
{
    public class Person : EntityBase
    {
        public Person()
        {

        }
        public Person(string name, DateTime dateOfBirth, RelationshipStatus relationshipStatus = RelationshipStatus.Unknown)
        {
            Id = Guid.NewGuid();
            Name = name;
            DateOfBirth = dateOfBirth.Date;
            RelationshipStatus = relationshipStatus;
        }

        [MaxLength(200)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public RelationshipStatus RelationshipStatus { get; set; }
    }
}
