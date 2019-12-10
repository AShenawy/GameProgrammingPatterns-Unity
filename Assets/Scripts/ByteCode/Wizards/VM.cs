using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VM : MonoBehaviour
{
    public GameObject[] player;
    //public int healthAmount = 100;
    //public int wisdomAmount;
    //public int agilityAmount;
    public AudioClip[] audioClips;
    public GameObject[] particleEffects;

    [Header("Instructions")]
    public Instructions instruction;
    private Stack valueStack = new Stack();
    private int value;

    private void Start()
    {

    }

    public void SortInstructions(int[] bytecode, int size)
    {
        for (int i = 0; i < bytecode.Length; i++)
        {
            instruction = (Instructions)bytecode[i];

            switch (instruction)
            {
                case Instructions.INST_SET_HEALTH:
                    int hPamount = PopOffStack();
                    int hPwizard = PopOffStack();
                    setHealth(hPwizard, hPamount);
                    print($"{player[hPwizard].name}'s health is affected by {hPamount}!");
                    break;

                case Instructions.INST_SET_WISDOM:
                    int wPamount = PopOffStack();
                    int wPwizard = PopOffStack();
                    setWisdom(wPwizard, wPamount);
                    print($"{player[wPwizard].name}'s wisdom is affected by {wPamount}!");
                    break;

                case Instructions.INST_SET_AGILITY:
                    int aPamount = PopOffStack();
                    int aPwizard = PopOffStack();
                    setAgility(aPwizard, aPamount);
                    print($"{player[aPwizard].name}'s agility is affected by {aPamount}!");
                    break;

                case Instructions.INST_PLAY_SOUND:
                    int soundID = PopOffStack();
                    playSound(soundID);
                    print($"{audioClips[soundID]} sound playing");
                    break;

                case Instructions.INST_SPAWN_PARTICLES:
                    int particleType = PopOffStack();
                    int targetWizard = PopOffStack();
                    spawnParticles(targetWizard, particleType);
                    print($"{particleEffects[particleType].name} spawned at {player[targetWizard].name}!");
                    break;

                case Instructions.INST_LITERAL:
                    value = bytecode[++i];
                    PushOnStack(value);
                    print($"Added {value} on the stack");
                    break;

                default:
                    break;
            }
        }
    }

    void PushOnStack(int value)
    {
        valueStack.Push(value);
    }

    int PopOffStack()
    {
        if (valueStack.Count > 0)
            return (int)valueStack.Pop();
        else
        {
            print("Spell stack empty.");
            return 0;
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

    void spawnParticles(int wizard, int particleType)
    {
        if (particleEffects.Length > 0)
            Instantiate(particleEffects[particleType], player[wizard].transform);
    }
}

public enum Instructions
{
    INST_SET_HEALTH = 100,
    INST_SET_WISDOM = 101,
    INST_SET_AGILITY = 102,
    INST_PLAY_SOUND = 103,
    INST_SPAWN_PARTICLES = 104,
    INST_LITERAL = 105
}
