using System;
using System.ComponentModel.DataAnnotations;

namespace NoteSystem.Models
{
    /// <summary>
    /// 鸡汤表
    /// </summary>
    
    public class ChickenSoup
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public Guid ChickenSoupGUID { set; get; }

        public ChickenSoup()
        {

        }
    }
}
