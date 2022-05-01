public class Car{

char type;

public Car(char type){
    type = type.ToString().ToUpper()[0];
    
    this.type = type;
}

public Car(Car objectOf){

    Car car = objectOf;
    this.type = objectOf.type;
}

public void SetType(char type){
    type = type.ToString().ToUpper()[0];
    this.type = type;
}

public void SetType(string type){
    

this.type = type.ToString().ToUpper()[0];


}

public char GetType(){

    return type;
}

public string GetTypeAsString(){

    if(type == '+')
    {
        return "Hybrid";
    }   

     if(type == 'H')
    {
        return "Hatchback";
    }   

     if(type == 'S')
    {
        return "Sedan";
    }   
     if(type == 'C')
    {
        return "Coupe";
    }   
    else return "Enter correct Type";


}

public int GetTankSize(){
    


    
    if(type == 'H'){

        
        return 10;
    }
    
    if(type == '+'){
       
        return 10;
    }

    if(type == 'S'){
       
        return 12;
    }

    if(type == 'C'){
        
        return 12;
    }
    else { 
        return 0;
    }

    

}

public int GetMPG(){


    

    if(type == 'H'){

        return 30;
    }
    
    if(type == '+'){
        return 50;
    }

    if(type == 'S'){
        return 25;
    }

    if(type == 'C'){
      
        return 280 / 12;
    }
    else return 0;

    


}

    public override string ToString()
    {
        string msg = "";

        msg += $"\n\n\nCar Type:{GetTypeAsString()} ";
        msg += $"\n\n\nMPG:{GetMPG()} ";
        msg += $"\n\n\nTank Size :{GetTankSize()} ";
       
       return msg;
    }

   
    public override bool Equals(object obj){
        
        Car car = (Car)obj;
        if(this.type == car.type) 
        {
            return true;
        }
        else return false;

       

    }
   
    
   

}





