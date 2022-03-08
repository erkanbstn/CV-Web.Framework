using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models.Entity
{
    public class Tables
    {
        public IEnumerable<TLinks> ResultLink { get; set; }
        public IEnumerable<THome> ResultHome { get; set; }
        public IEnumerable<TContact> ResultContact { get; set; }
        public IEnumerable<TFacts> ResultFacts { get; set; }
        public IEnumerable<TPortfolio1> ResultPortfolio1 { get; set; }
        public IEnumerable<TPortfolio2> ResultPortfolio2 { get; set; }
        public IEnumerable<TResume1> ResultResume1 { get; set; }
        public IEnumerable<TResume2> ResultResume2 { get; set; }
        public IEnumerable<TServices> ResultServices { get; set; }
        public IEnumerable<TSkills> ResultSkills { get; set; }
        public IEnumerable<CVAdmin> ResultAdmin { get; set; }
        public IEnumerable<TMessages> ResultMessages { get; set; }
        public IEnumerable<TAbout> ResultAbout { get; set; }
    }
}