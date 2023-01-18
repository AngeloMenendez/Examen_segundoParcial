  class comercial:Empleados{
     
   public double comision{get;set;}
    
    public comercial (string nombre,int edad ,double salario,double comision):base(nombre,edad,salario){
    this.comision=comision;
    }
    public void PlusC()
    {
      if(edad<30)
      {
        salario=salario+250;
      }
    }
 public void mostrar(){
Console.WriteLine("el nombre es "+nombre+"la edad es "+edad+ "el salario es "+salario +"la comisión es"+comision);

 }
}