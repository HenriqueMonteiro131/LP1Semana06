namespace GameSix
{
    public class Foe
    {
        
    }

    public Foe (string name)
    {
        this.name = name;
        health = 100;
        shield =0; 

    }

    public  string GetName()
    {
        return name;
    }

    public  string GetHealth()
    {
        return health;
    }

    public  string GetShield()
    {
        return shield;
    }

    public  string SetName()
    {
        string name = "Kebb";
        name = name.Trim();


        return Kebb;
    }

    public void Takedamage (float damage)
    {

        shield -= damage;
        if (shield < 0)
        {

            float damageStillToInflict = - shield;
            shield  = 0;
            health -= damageStillToInflict;
            if (health < 0) health = 0;


        }


    }
}