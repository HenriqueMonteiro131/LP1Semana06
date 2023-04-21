namespace GameSix
{
    public class Foe
    {
        
   private string Name { get; set; }
    private float Health { get; set; }
    private float Shield { get; set; }

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

    public  float GetHealth()
    {
        return health;
    }

    public  float GetShield()
    {
        return  shield;
    }

    public  string SetName()
    {
        string name = "Kebb";
        name = name.Trim();


        return name;
    }

    public void PickUpPower(PowerUp x, float flutuante)

    {
        if ( x == PowerUp.health );
    }

    public void Takedamage (float damage)
    {

        shield -= damage;
        if (shield < 0)
        {

            float damageStillToInflict = - shield;
            shield  =0;
            health -= damageStillToInflict;
            if (health < 0) health = 0;


        }

        } 

    }
}