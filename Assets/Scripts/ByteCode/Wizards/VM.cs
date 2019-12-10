using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VM : MonoBehaviour
{
    public GameObject[] player;
    //public int healthAmount;
    //public int wisdomAmount;
    //public int agilityAmount;
    public AudioClip[] audioClips;
    public GameObject[] particleEffects;

    [Header("Instructions")]
    public Instructions instructions;

    private void Start()
    {

    }

    public void SortInstructions()
    {
        switch(instructions)
        {
            case Instructions.INST_SET_HEALTH:
                setHealth(0, 100);
                break;
            case Instructions.INST_SET_WISDOM:
                setWisdom(0, 100);
                break;
            case Instructions.INST_SET_AGILITY:
                setAgility(0, 100);
                break;
            case Instructions.INST_PLAY_SOUND:
                playSound(0);
                break;
            case Instructions.INST_SPAWN_PARTICLES:
                spawnParticles(0);
                break;
        }
    }

    void setHealth(int wizard, int amount)
    {
        player[wizard].GetComponent<Wizard>().health += amount;
    }

    void setWisdom(int wizard, int amount)
    {
        player[wizard].GetComponent<Wizard>().wisdom += amount;
    }

    void setAgility(int wizard, int amount)
    {
        player[wizard].GetComponent<Wizard>().agility += amount;
    }

    void playSound(int soundId)
    {
        if(audioClips.Length > 0)
            AudioSource.PlayClipAtPoint(audioClips[soundId], Vector3.zero);
    }

    void spawnParticles(int particleType)
    {
        if (particleEffects.Length > 0)
            Instantiate(particleEffects[particleType], player[0].transform);
    }
}
public enum Instructions
{
    INST_SET_HEALTH = 0x00,
    INST_SET_WISDOM = 0x01,
    INST_SET_AGILITY = 0x02,
    INST_PLAY_SOUND = 0x03,
    INST_SPAWN_PARTICLES = 0x04
}
