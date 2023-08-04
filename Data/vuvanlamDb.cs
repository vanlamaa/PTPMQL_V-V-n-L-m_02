using vuvanlam_02.Models;
using Microsoft.EntityFramewordCore;


namespace vuvanlam_02.Data
{
    public class vuvanlamDb 
    {   
        public vuvanlamDb (DbContextOptions<vuvanlamDb> options) : base(options)
        {}
        
    }
}