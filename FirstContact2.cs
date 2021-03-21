//using System;

//namespace FirstContact_Csharp2 {
//    class Program {


//        //static void SayHi() {
//        //    Console.WriteLine("hi!");
//        //}
//        //static string SayHi() {
//        //    return "hi!";
//        //}
//        static string SayHi() => "hi!";


//        static void Main()
//        {
//            Console.WriteLine(SayHi());


//        }
//    }
//}

//---2
//using System;

//namespace FirstContact_Csharp2 {
//    class Program {


//        static void SayHi(string name, int age = 23) {
//            Console.WriteLine($"hi! {name} ({age})");
//        }

//        static void Main() {
//            SayHi("Tom", 30);
//            SayHi("Tom");
//            SayHi(age: 26, name: "steve");

//        }
//    }
//}

//---2
//using System;

//namespace FirstContact_Csharp2 {

//    class User {
//        public string name = "me";
//        public void SayHi() {
//            //Console.WriteLine($"hi {this.name}");
//            Console.WriteLine($"hi {name}");
//        }
//    }

//    class Program {

//        static void Main() {
//            User user = new User();
//            Console.WriteLine(user.name);
//            user.SayHi();
//        }
//    }
//}

//-----
//using System;

//namespace FirstContact_Csharp2 {

//    class User {
//        public string name;
//        //public User() {
//        //    this.name = "ME";
//        //}
//        public User(string name) {
//            this.name = name;
//        }
//        //public User() {
//        //    this.name = "nobody";
//        //}
//        public User(): this("nobody") {

//        }
//        public void SayHi() {
//            Console.WriteLine($"hi {name}");
//        }
//    }

//    class Program {

//        static void Main() {
//            //User user = new User();
//            //user.SayHi();
//            User tom = new User("Tom");
//            tom.SayHi();
//            User user = new User();
//            user.SayHi();
//        }
//    }
//}


//-----
//using System;

//namespace FirstContact_Csharp2 {

//    class User {
//        public string name;
//        public User(string name) {
//            this.name = name;
//        }
//        public virtual void SayHi() {
//            Console.WriteLine($"hi {name}");
//        }
//    }

//    class AdminUser: User {
//        public AdminUser(string name): base(name) {
//        }
//        public void SayHello() {
//            Console.WriteLine($"hello {name}");
//        }
//        public override void SayHi() {
//            Console.WriteLine($"[admin] hi {name}");
//        }
//    }

//    class Program {

//        static void Main() {
//            User tom = new User("Tom");
//            tom.SayHi();
//            AdminUser bob = new AdminUser("Bob");
//            bob.SayHi();
//            bob.SayHello();
//        }
//    }
//}

//------
//using System;

//namespace FirstContact_Csharp2 {

//    class User {
//        //public string name;
//        //protected string name;
//        private string name;
//        public User(string name) {
//            this.name = name;
//        }
//        public virtual void SayHi() {
//            Console.WriteLine($"hi {name}");
//        }
//    }

//    class AdminUser : User {
//        public AdminUser(string name) : base(name) {
//        }
//        public void SayHello() {
//            Console.WriteLine($"hello {name}");
//        }
//        public override void SayHi() {
//            Console.WriteLine($"[admin] hi {name}");
//        }
//    }

//    class Program {

//        static void Main() {
//            User tom = new User("Tom");
//            Console.WriteLine(tom.name);
//            tom.SayHi();
//            AdminUser bob = new AdminUser("Bob");
//            bob.SayHi();
//            bob.SayHello();
//        }
//    }
//}

using System;

namespace FirstContact_Csharp2 {

    class User {
        private string name = "me!";

        public string Name {
            get { return this.name; }
            set {
                if (value != "") {
                    this.name = value;
                }
            }
        }
        //public string Name { get; set; } = "me!";
    }

    class Program {

        static void Main() {
            User user = new User();
            Console.WriteLine(user.Name);
            user.Name = "taguchi";
            Console.WriteLine(user.Name);
            user.Name = "";
            Console.WriteLine(user.Name);
        }
    }
}