internal class Program
{
    private static void Main(string[] args){

       comercial c1 = new comercial ("Luis",35,300,100);
       repatidor r1= new repatidor("Andy",30,400,"zona3");
       c1.PlusC();
       r1.PlusR();
    }
}