using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Game.Controllers
{
    public class GameController : Controller
    {
        // GET: /<controller>/
        public string answer { get; set; }
        static List<string> list = new List<String>();
        static List<string> story= new List<string>();
        static List<string> studystory = new List<string>();
        static List<string> gamestory = new List<string>();
        static List<string> kitchenstory = new List<string>();
        static List<string> gardenstory = new List<string>();
        static int tvclick = 0;
        static int sofaclick = 0;
        static int hintclick = 0;
        static int studyclick = 0;

        static int fishlick = 0;


        public IActionResult Index()
        {

            return View();
        }
        public IActionResult TV()
        {
            tvclick += 1;
            if (tvclick == 1)
            {
                story.Add("Dear my child, everything changes all the time. ");
            }
            else if(tvclick == 2)
            {
                story.Add("when I was a mom, I get a front row seat to the best show in town: watching your grow up. ");
            }
            else

            {
                story.Add("Let's join this beautiful day!");
            }

            return RedirectToAction("Firstroom", "Game");
        }

        public IActionResult Sofa()
        {
            sofaclick += 1;
            if (sofaclick == 1)
            {
                story.Add("you find a key");
                if (!list.Contains("key"))
                 {
                   list.Add("key");
                   }


            }



            return RedirectToAction("Livingroom", "Game");
        }

        public IActionResult Coffee()
        {

            return RedirectToAction("Livingroom", "Game");
        }


        public IActionResult Fish()
        {
            fishlick += 1;
            if (fishlick == 1)
            {
                story.Add("Do you remember this fishing rod which I send you last year?");
                if(!list.Contains("Fish Rod"))
                {
                    list.Add("Fish Rod");
                }

            }
            else
            {
                story.Add("Do you remember this fishing rod which I send you last year?");
            }


            return RedirectToAction("Livingroom", "Game", list);
        }

        public IActionResult Livinghint()
        {
            hintclick += 1;
            if (hintclick == 1)
            {
                story.Add("hint: You can try to click something");
            }
            else
            {
                story.Add("hint: the key which open the case may not in this room");
            }
            return RedirectToAction("Livingroom","Game");
        }



        public IActionResult Case()
        {
            list.Remove("key2");
            story.Add("Great! And here is your FiRsRT hint: HHHHappiness is very important in life");
            return RedirectToAction("Livingroom", "Game", list);
        }

        public IActionResult Wrongchoice()
        {
            story.Add("Coffee table looks like bad...we should fix it");
            return RedirectToAction("Livingroom", "Game", list);
        }
        public IActionResult Wrongchoicecase()
        {
            story.Add("I can't open it!");
            return RedirectToAction("Livingroom", "Game", list);
        }
        public IActionResult Level1()
        {
            gamestory.Add("Stop studying! Let's play");
            return RedirectToAction("Gameroom", "Game");
        }
        public IActionResult Level2()
        {
            if(gamestory.Contains("Great! And here is your FourTh hint: D is an important word"))
            {
                gamestory.Add("Check next room");
            }
            else { gamestory.Add("Great! And here is your FourTh hint: D is an important word"); }

          return RedirectToAction("Gameroom", "Game");
        }

        public IActionResult Livingroom()
        {
            ViewBag.Story = story;
            return View(list);
        }


        public IActionResult Firstroom()
        {
            ViewBag.Story = story;
            return View(list);
        }
        public IActionResult Gameroom()
        {
            ViewBag.GameStory = gamestory;
            return View(list);
        }

        public IActionResult Gamehint()
        {
            gamestory.Add("hint:minions are so cute! click them!");
            return RedirectToAction("Gameroom", "Game");
        }
        public IActionResult view2()
        {
            ViewBag.Study = studystory;
            return View();
        }

        public IActionResult Study1()
        {

            return View(list);
        }

        public IActionResult Paper()
        {
            return RedirectToAction("Studyroom", "Game");
        }

        public IActionResult Studyroom()
        {

            ViewData["Riddle"] = "I believe you are a clever child";
            ViewBag.Study = studystory;
            return View(list);
        }

        public IActionResult Sshint()
        {
            studystory.Add("Did you see a note on a table..");
            return RedirectToAction("Studyroom", "Game");
        }

        public IActionResult Read()
        {
            studyclick += 1;
            if (studyclick == 1)
            {
                studystory.Add("What seems to be written on the paper");
            }
            else if(studyclick ==2){
                studystory.Add("In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?");
            }else if (studyclick ==3)
            {
                studystory.Add("Guess");
            }

            ViewData["Riddle"] = "Now you are in the study room and see a note on a table...you take the note";
            ViewData["Read"] = "It reads...there is an ancient riddle:";
            ViewData["Riddle1"] = "In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?";

            return RedirectToAction("Studyroom", "Game"); 

        }


        [HttpPost]
        public IActionResult Input(string answer)
        {

            ViewData["Riddle"] = "Now you are in the study room and see a note on a table...you take the note";
            this.answer = answer;
            if (string.IsNullOrEmpty(answer))
            {

                TempData["sorry1"] = "<script>alert('Just Guess');</script>";
                ViewData["Read"] = "It reads...there is an ancient riddle...";
                ViewData["Riddle1"] = "In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?";
            }


            else
            {
                string str = answer.ToLower();

                ViewData["Read"] = "It reads...there is an ancient riddle...";
                ViewData["Riddle1"] = "In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?";

                if (str == "human" || str == "men" || str == "women" || str == "woman" || str == "man")
                {
                    studystory.Add("Congrats! And here is your SeConD hint: what does PePPer have most");
                    TempData["msg"] = "<script>alert('Congrats! And here is your SeConD hint: what does PePPer have most');</script>";
                }
                else if (!string.IsNullOrEmpty(str) && str != "human" || str != "men" || str != "women" || str != "woman" || str != "man")
                {
                    TempData["sorry"] = "<script>alert('Not quite right...Please try again!');</script>";


                }
            }

            return RedirectToAction("Studyroom", "Game");

        }
        public IActionResult Shint()
        {

            ViewData["shint"] = "There are paper on the desk";
            return View("Study1",list);
        }
        //}
        //public IActionResult Studyroom()
        //{

        //    ViewData["Riddle"] = "Now you are in the study room and see a note on a table...you take the note";
        //    return View();
        //}

        //public IActionResult Read()
        //{
        //    ViewData["Riddle"] = "Now you are in the study room and see a note on a table...you take the note";
        //    ViewData["Read"] = "It reads...there is an ancient riddle:";
        //    ViewData["Riddle1"] = "In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?";

        //    return View("Studyroom");

        //}


        //[HttpPost]
        //public IActionResult Input(string answer)
        //{

        //    ViewData["Riddle"] = "Now you are in the study room and see a note on a table...you take the note";
        //    this.answer = answer;
        //    if (string.IsNullOrEmpty(answer))
        //    {

        //        ViewBag.MessageSorry1 = "Just Guess!";
        //        ViewData["Read"] = "It reads...there is an ancient riddle...";
        //        ViewData["Riddle1"] = "In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?";
        //    }


        //    else
        //    {
        //        string str = answer.ToLower();

        //        ViewData["Read"] = "It reads...there is an ancient riddle...";
        //        ViewData["Riddle1"] = "In general,what goes on four legs at dawn, two legs at noon, and three legs in the evening?";

        //        if (str == "human" || str == "men" || str == "women" || str == "woman" || str == "man")
        //        {
        //            ViewBag.MessageGuess = "Congrats! And here is your SeConD hint: what does PePPer have most";//changed
        //        }
        //        else if (!string.IsNullOrEmpty(str) && str != "human" || str != "men" || str != "women" || str != "woman" || str != "man")
        //        {
        //            ViewBag.MessageSorry = "Not quite right...Please try again!";


        //        }
        //    }

        //    return View("Studyroom");

        //}
        public IActionResult Dining1()
        {

            return View(list);

        }
        public IActionResult DiningRoom()
        {
            ViewData["Intro1"] = "Then you go to dining room for another hint.";
            ViewData["Intro2"] = "You see a little robot";
            ViewBag.List = list;
            return View();

        }

        public IActionResult Robot()
        {
            ViewData["Intro1"] = "Then you go to dining room for another hint.";
            ViewData["Intro2"] = "You see a little robot";
            ViewData["Intro"] = "Hi,I'm Arya! Please enter five items you want for birthday." + " " +
                "Make sure to shuffle it.I will guess one item that you want the most.You " +
                "will need some luck here.Because I'm a little bit dumb...";


            return View("DiningRoom");

        }
        //int sum = 0;
        Random rnd = new Random();



        public static List<string> glist = new List<string>();
        Guess guess = new Guess();
        static string h = String.Empty;
        static string firstitem;
        static string present;
        public IActionResult Click2(Guess g)
        {
            ViewData["Intro1"] = "Then you go to dining room for another hint.";
            ViewData["Intro2"] = "You see a little robot";
            if (string.IsNullOrEmpty(g.a) || string.IsNullOrEmpty(g.b) || string.IsNullOrEmpty(g.c) || string.IsNullOrEmpty(g.d) || string.IsNullOrEmpty(g.e))
            {
                TempData["empty2"] = "<script>alert('Please enter all your five most favorite presents');</script>";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";

            }

            else
            {
                glist.Add(g.a);
                glist.Add(g.b);
                glist.Add(g.c);
                glist.Add(g.d);
                glist.Add(g.e);
                h = g.a;
                present = h;
            }
            if (glist.Count() != glist.Distinct().Count())
            {

                TempData["empty3"] = "<script>alert('Please enter five different presents');</script>";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";
                glist.Clear();
            }
            ViewData["Intro"] = "Hi,I'm Arya! Please enter five items you want for birthday." + " " +
                "Make sure to shuffle it.I will guess one item that you want the most.You " +
                "will need some luck here.Because I'm a little bit dumb...";
 
            return View("DiningRoom");
        }


        public IActionResult Click3()
        {
            if (glist.Count.Equals(0))
            {

                ViewBag.Message = "You haven not enter any presents for me to guess yet";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";

            }
            else
            {
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";
                //glist.Add("Triscuit");//added
                //glist.Add("Pringles");//added
                //glist.Add("Pizza");//added
                Shuffle(glist);


                firstitem = glist[0];
                if (string.IsNullOrEmpty(firstitem) || string.IsNullOrEmpty(h))
                {
                    TempData["empty"] = "<script>alert('Please enter your five most favorite presents');</script>";
                    ViewData["Intro1"] = "Then you go to dining room for another hint.";
                    ViewData["Intro2"] = "You see a little robot";
                }

                else if (firstitem.Equals(h))
                {

                    TempData["hint"] = "<script>alert('I feel like this guess would be correct!');</script>";
                    ViewData["Intro1"] = "Then you go to dining room for another hint.";
                    ViewData["Intro2"] = "You see a little robot";

                }
                ViewData["first"] = firstitem;
            }
            ViewData["Intro"] = "Hi,I'm Arya! Please enter five items you want for birthday." + " " +
                "Make sure to shuffle it.I will guess one item that you want the most.You " +
                "will need some luck here.Because I'm a little bit dumb...";
 
            return View("DiningRoom");

        }

        public IActionResult No()
        {
            if (glist.Count.Equals(0))
            {

                //ViewData["empty1"] = "You haven't enter any presents for me to guess yet";
                ViewBag.Message = "You haven not enter any presents for me to guess yet";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";


            }
            else if (string.IsNullOrEmpty(firstitem) || string.IsNullOrEmpty(h))
            {
                TempData["empty"] = "<script>alert('Please enter your five most favorite presents');</script>";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";
            }
            else if (!firstitem.Equals(h))
            {
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";

            }
            else if (firstitem.Equals(h))
            {

                ViewBag.MessageNo = "No way,I think it is correct. You are teasing me :( I will not guess any more";
                //changed
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";
                glist.Clear();//added
            }
            //else
            //{
            //    Shuffle(glist);

            //}
            ViewData["Intro"] = "Hi,I'm Arya! Please enter five items you want for birthday." + " " +
                "Make sure to shuffle it.I will guess one item that you want the most.You " +
                "will need some luck here.Because I'm a little bit dumb...";
 
            return View("DiningRoom");

        }


        public IActionResult Shuffle1()
        {
            ViewData["Intro1"] = "Then you go to dining room for another hint.";
            ViewData["Intro2"] = "You see a little robot";
            ViewData["Intro"] = "Hi,I'm Arya! Please enter five items you want for birthday." + " " +
                "Make sure to shuffle it.I will guess one item that you want the most.You " +
                "will need some luck here.Because I'm a little bit dumb...";

            if (glist.Count.Equals(0))
            {

                TempData["empty1"] = "<script>alert('You haven't enter any presents for me to guess yet');</script>";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";


            }

            else
            {
                glist.Add("Triscuit");//added
                glist.Add("Pringles");//added
                glist.Add("Pizza");//added
                for (int i = 0; i < 10; i++)
                {
                    Shuffle(glist);
                }
            }

            return View("DiningRoom");

        }

        public IActionResult Yes()
        {
            if (glist.Count.Equals(0))
            {

                ViewBag.Message1 = "You haven not enter any presents for me to guess yet";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";


            }
            else if (string.IsNullOrEmpty(firstitem) || string.IsNullOrEmpty(h))
            {
                TempData["empty"] = "<script>alert('Please enter your five most favorite presents');</script>";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";
            }

            else if (!firstitem.Equals(h))
            {

                ViewBag.Message2 = "I do not really think this is what you want most...Just keep me gussing!";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";

            }
            else if (firstitem.Equals(h))
            {
                TempData["hint1"] = "<script>alert('Great! And here is your ThIrD hint: what does BuBBle have most');</script>";
                ViewData["Intro1"] = "Then you go to dining room for another hint.";
                ViewData["Intro2"] = "You see a little robot";
                ViewData["clue"] = "Great! And here is your ThIrD hint: what does BuBBle have most ";
                glist.Clear();
            }
            ViewData["Intro"] = "Hi,I'm Arya! Please enter five items you want for birthday." + " " +
                "Make sure to shuffle it.I will guess one item that you want the most.You " +
                "will need some luck here.Because I'm a little bit dumb..."; 
            return View("DiningRoom");

        }
        public void Shuffle(List<string> glist)
        {
            int N = glist.Count;
            for (int i = 0; i < N; i++)
            {
                int r = rnd.Next(i + 1);
                Swap(glist, i, r);
            }
        }

        public void Swap(List<string> glist, int i, int j)
        {
            string temp = glist[i];
            glist[i] = glist[j];
            glist[j] = temp;
        }
        static Password code1 = new Password();

        //public IActionResult Present()
        //{
        //    ViewBag.Garden = gardenstory;
        //    ViewBag.List = list;
        //    ViewData["Case"] = "Then you are in the garden and you see a box which is locked";
        //    ViewBag.List = list;
        //    return View();

        //}

        //public IActionResult Present1(Password code)
        //{
        //    ViewData["Case"] = "Then you are in the garden and you see a box which is locked";
        //    code1.a = code.a;
        //    code1.b = code.b;
        //    code1.c = code.c;
        //    code1.d = code.d;
        //    if (code.a == "h" && code.b == "p" && code.c == "b" && code.d == "d")
        //    {
        //        TempData["msg1"] = "<script>alert('Yayyy!Present is now unlocked!Happy Birthday!!');</script>";
        //        ViewData["Case"] = "Then you are in the garden and you see a box which is locked";
        //        ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";
        //        ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code to open";
        //    }

        //    if (code.a != "h" || code.b != "p" || code.c != "b" || code.d != "d"
        //    && !string.IsNullOrEmpty(code.a) && !string.IsNullOrEmpty(code.b) && !string.IsNullOrEmpty(code.c) && !string.IsNullOrEmpty(code.d))

        //    {
        //        ViewBag.Messagecode = "Almost there, just give another try!";
        //        ViewData["Case"] = "Dearling, you are almost there";
        //        ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";
        //        ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code to open";
        //    }


        //    return View("Present", code);

        //}

        //public IActionResult SeePresent()
        //{
        //    //ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code to open";
        //    //ViewData["seePresent"] = present;
        //    //if (code1.a != "h" || code1.b != "p" || code1.c != "b" || code1.d != "d")
        //    //{
        //    //    TempData["presentlocked"] = "<script>alert('Present is still locked');</script>";
        //    //    return View("Present");

        //    //}
        //    //else
        //    //{

        //    //    return View("SeePresent");
        //    //}
        //    ViewData["seePresent"]="1";
        //    return View();
        //}
        //public IActionResult PresentContinue()
        //{


        //    ViewData["Case"] = "Then you are in the garden and you see a box which is locked";
        //    ViewData["pcontinue"] = "YaY! You find a present in the box, but needs code to open";

        //    ViewBag.List = list;
        //    if (list.Contains("key"))
        //    {
        //        gardenstory.Add("YaY! You find a present in the box, but needs code to open");
        //        list.Remove("key");
        //    }
        //    else {
        //        gardenstory.Add("You need find a key to open it");
        //    }
        //    // return View("Present");
        //    return RedirectToAction("Present","Game");
        //}
        //public IActionResult Ghint()
        //{

        //    gardenstory.Add("Click box");
          
        //    return RedirectToAction("Present", "Game");
        //}

        //public IActionResult PresentContinue1()
        //{
        //    gardenstory.Add("YaY! You find a present in the box, but needs code to open");
        //    ViewData["Case"] = "Then you are in the garden and you see a box which is locked";

        //    ViewData["pcontinue"] = "YaY! You find a present in the box, but needs code to open";
        //    //return View("Present");
        //    return RedirectToAction("Present","Garden");
        //}

        public IActionResult Present()
        {
            ViewBag.List = list;
            ViewData["Case"] = "Woo, you are in the last step to get your gift!";

            return View();

        }
        static string locker = "No";

        public IActionResult Present1(Password code)
        {
            ViewBag.List = list;
            ViewData["Case"] = "Woo, you are in the last step to get your gift!";

            code1.a = code.a;
                code1.b = code.b;
                code1.c = code.c;
                code1.d = code.d;
            //string str1 = code.a.ToLower();
            //string str2 = code.b.ToLower();
            //string str3 = code.c.ToLower();
            //string str4 = code.d.ToLower();
            //code1.a = str1;
            //code1.b = str2;
            //code1.c = str3;
            //code1.d = str4;
            //if (!string.IsNullOrEmpty(code.a) && !string.IsNullOrEmpty(code.b) && !string.IsNullOrEmpty(code.c) && !string.IsNullOrEmpty(code.d))
            //{
            //    TempData["msg3"] = "<script>alert('Almost there!!');</script>";
            //}
            //if (str1 == "h" && str2 == "p" && str3 == "b" && str4 == "d")
            if (code.a == "H" && code.b == "P" && code.c == "B" && code.d == "D")
            {
                locker = "Yes";
                TempData["msg1"] = "<script>alert('Yayyy!Present is now unlocked!Happy Birthday!!');</script>";
                ViewData["Case"] = "Woo, you are in the last step to get your gift!";
                ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";
                ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code to open <- ";
            }

            else if (code.a != "h" || code.a != "H"||code.b != "p" || code.b != "P"||code.c != "b" || code.c != "B" ||code.d != "d" || code.d != "D"
            && !string.IsNullOrEmpty(code.a) && !string.IsNullOrEmpty(code.b) && !string.IsNullOrEmpty(code.c) && !string.IsNullOrEmpty(code.d))

            {
                locker = "No";
                ViewBag.Messagecode = "Almost there, just give another try!";
                ViewData["Case"] = "Woo, you are in the last step to get your gift!";
                ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";
                ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code to open <-";
            }


            return View("Present", code);

        }


        public IActionResult SeePresent()
        {
            ViewData["Case"] = "Woo, you are in the last step to get your gift!";
            ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";
            ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code to open <-";
            ViewData["seePresent"] = present;
            if (locker == "No")
            {
                ViewBag.List = list;
                TempData["presentlocked"] = "<script>alert('Present is still locked');</script>";
                return View("Present");

            }
            else
            {
                ViewBag.List = list;

                return View("SeePresent");
            }




        }
        public IActionResult PresentContinue()
        {
            ViewData["Case"] = "Woo, you are in the last step to get your gift!";
            ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";

            ViewBag.List = list;
            if (list.Contains("key1"))
            {
                list.Remove("key1");
            }
            return View("Present");
        }

        public IActionResult PresentNoContinue()
        {
            ViewData["Case"] = "Woo, you are in the last step to get your gift!";
            ViewData["nocontinue"] = "You should find key";

            ViewBag.List = list;

            return View("Present");
        }
        public IActionResult PresentContinue1()
        {
            ViewBag.List = list;
            ViewData["Case"] = "Woo, you are in the last step to get your gift!";
            ViewData["pcontinue"] = "You used key you get from the first room and open the case <-";
            ViewData["pcontinue1"] = "Yeah!!there is a present in the box but needs code  to open <-";
            return View("Present");
        }
        public IActionResult Kitchen()
        {
            ViewBag.KitchenStory = kitchenstory;
            return View(list);
        }
        public IActionResult Khint()
        {
            kitchenstory.Add("Hint: Click fish tank");
            return RedirectToAction("Kitchen", "Game");
        }


        public IActionResult Continue4()
        {
            kitchenstory.Add("Yeah! You find other key. There are something still locked..");
            list.Remove("Fish Rod");
            list.Add("key2");
            return RedirectToAction("Kitchen", "Game");
        }
        public IActionResult Wrong()
        {
            if (list.Contains("Fish Rod"))
            {
                kitchenstory.Add("There are something in the bottom of this tank");
                list.Remove("Fish Rod");
            }
            else
            {
                kitchenstory.Add("Don't forget clean tank");
            }

            return RedirectToAction("Kitchen", "Game");
        }

    }


}
