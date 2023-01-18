class repatidor:Empleados{
    
   public string zona{get;set;}
    
    public repatidor (string nombre,int edad ,double salario,string zona):base(nombre,edad,salario){
    this.zona=zona;
    }
    public void PlusR()
    {
        if (edad<25){
            salario=salario+100;
        }
    }
 public void mostrar(){
Console.WriteLine("el nombre es "+nombre+"la edad es "+edad+ "el salario es "+salario +"la zona es" +zona);
  }
}






