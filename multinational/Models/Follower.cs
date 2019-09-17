using System;
using System.ComponentModel.DataAnnotations;

namespace multinational.models{

    public class Follower{
        public int ID{get;set;}
        public String producto{get;set;}
        public String categoria{get;set;}
        public String radio{get;set;}
        public Double precio{get;set;}

        public Double imp{get;set;}


    }


}