namespace WebApplication15.Models
{
    public static class Database
    {
        static List<Persona> MyList = new List<Persona>(){
                new Persona{Id = 1, Name = "Valerio", Surname = "Valdes"},
                new Persona{Id = 2, Name = "Gigi", Surname = "Sabbani"},
                new Persona{Id = 3, Name = "Mario", Surname = "Rossi"},
                new Persona{Id = 4, Name = "Gianni", Surname = "Rodari"}
            };

        public static List<Persona> GetList()
        {
            return MyList;
        }
        public static void AddPerson(Persona p)
        {
            var maxId = MyList.Max(i => i.Id);
            p.Id = maxId + 1;
            MyList.Add(p);
        }

        public static Persona GetPerson(int id)
        {
            return MyList.FirstOrDefault(p => p.Id == id)!;
        }

        public static void Replace(Persona p)
        {
            var persona = MyList.FirstOrDefault(i => i.Id == p.Id);
            MyList.Remove(persona);
            MyList.Add(p);
        }
    }
}
