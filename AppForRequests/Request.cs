using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForRequests
{
    class Request { 
        private string requestNumber
        {
            get; set;
        }
        private string nameOfDetail
        {
            get; set;
        }
        private int countOfDetail
        {
            get; set;
        }
        public Request(string requestNumber, string nameOfDetail, int countOfDetail)
        {
            this.requestNumber = requestNumber;
            this.nameOfDetail = nameOfDetail;
            this.countOfDetail = countOfDetail;
        }  
    }
}
