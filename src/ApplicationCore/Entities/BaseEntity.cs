using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    //abs yaptık çünkü miras alınacak
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; } 
    }
}
