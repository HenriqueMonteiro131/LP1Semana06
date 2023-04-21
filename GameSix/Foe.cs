namespace GameSix
{
    public class Foe
    {
        
    }

    public Foe (string name)
    {
        this.name=name;
        health = 100;
        shield = 0; 

    }

    public  string GetName()
    {
        return name;
    }

    public void Takedamage (float damage)
    {

        shield -= damage;
        if (shield < 0)
        {



            
        }


    }
}