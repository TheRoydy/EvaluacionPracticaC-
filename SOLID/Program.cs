using System.Xml.Linq;

namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yordy = new Persona("Yordy");
            yordy.Speak();

            var cristian = new Manager("Cristian");
            var director = new Director("Jose");
            var database = new Database();
            database.SaveToDatabe(yordy);

            var calculator =  new SalaryCalculator();
            Console.WriteLine($"El salario de {yordy.Name} es {calculator.CalculateSalary(yordy)}");
            Console.WriteLine($"El salario de {cristian.Name} es {calculator.CalculateSalary(cristian)}");
            Console.WriteLine($"El salario de {director.Name} es {calculator.CalculateSalary(director)}");

        }
    }


    public class Persona
    {
        public virtual decimal DailyRate => 0;
        public Persona(string name) 
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void Speak() 
        {
            Console.WriteLine($"Mi nombre es {Name}");
        }

       
    }

    public class Employee : Persona
    {
        public override decimal DailyRate => 100;
        public Employee(string name) : base(name)
        {
        }
    }

    public class Manager : Persona
    {
        public override decimal DailyRate => 200;
        public Manager(string name) : base(name)
        {
        }
    }

    public class Director : Persona
    {
        public Director(string name) : base(name)
        {
        }

        public override decimal DailyRate => 300;
    }

    public class SalaryCalculator
    {
        public decimal CalculateSalary(Persona persona)
        {
            return persona.DailyRate * 365;
        }
    }
    public class Database
    {
        public void SaveToDatabe(Persona persona)
        {
            Console.WriteLine($"Guarde {persona.Name}");
        }
    }

    public interface IRepository 
    {
        bool Create(Persona persona);
        Persona Get(int id);
        IEnumerable<Persona> GetAll();
        bool Update(Persona persona);
        bool Delete(int id);
    }

    public interface IGettableRepository
    {
        Persona Get(int id);
        Persona GetAll();
    }

    public interface IUpdatetableRepository
    {
        bool Update(Persona persona);
    }

    public interface IDeletetableRepository
    {
        bool Delete(int id);
    }
    public interface ICreatableRepository
    {
        bool Create(Persona persona);
    }

    public class ReadOnlyRepository : IGettableRepository
    {
        public Persona Get(int id)
        {
            throw new NotImplementedException();
        }

        public Persona GetAll()
        {
            throw new NotImplementedException();
        }
    }

    public class CrudRepository : ICreatableRepository, IGettableRepository, IUpdatetableRepository, IDeletetableRepository
    {
        public bool Create(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Persona Get(int id)
        {
            throw new NotImplementedException();
        }

        public Persona GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Persona persona)
        {
            throw new NotImplementedException();
        }
    }

} 
