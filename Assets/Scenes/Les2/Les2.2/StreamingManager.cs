using UnityEngine;

public class StreamingManager : MonoBehaviour
{
    [Header("Character Info")]
    public string playerName = "Mary";
    public int level = 7;
    public string characterClass = "Mage";

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 75;
    public int attack = 50;
    public int defense = 25;

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 200;
    public float playtimeHours = 4.5f;
    public bool hasCompletedTutorial = true;

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 5;
    public string currentWeapon = "Iron Sword";

    void Start()
    {
        DisplayCharacterSheet();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            level++;
            maxHealth += 5;
            health = maxHealth;
            attack += 2;
            defense += 3;
            mana += 5;


            Debug.Log("LEVEL UP! New level" + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/");
                Debug.Log("POtions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            DisplayCharacterSheet();
        }
    }

    private void DisplayCharacterSheet()
    {
        //Display Character Sheet
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}
