using System;
using Microsoft.AspNetCore.Mvc;
using multinational.models;

namespace multinational.controllers{

    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(){
            Console.WriteLine("Index");
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Follower follow){
            Console.WriteLine("Registrar");
            
        
            
            if(follow.radio=="nacional"){
                follow.imp=follow.precio-(follow.precio*0.1);
                
                if(follow.categoria=="camioneta"){
                    follow.imp=follow.imp-(follow.imp*0.05);
                }else follow.imp=follow.imp-(follow.imp*0.03);

            }else if(follow.radio=="extranjero"){
                follow.imp=follow.precio-(follow.precio*0.3);
                  if(follow.categoria=="camioneta"){
                    follow.imp=follow.imp-(follow.imp*0.05);
                }else follow.imp=follow.imp-(follow.imp*0.03);     
            }

            _context.Add(follow);
            _context.SaveChanges();

            return View(follow);

            }        
        }

    }

