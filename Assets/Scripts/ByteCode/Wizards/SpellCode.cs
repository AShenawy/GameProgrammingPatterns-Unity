using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCode : MonoBehaviour
{
    public VM virtualMachine;
    public int[] spellCodes;

    public void CastSpell()
    {
        virtualMachine.SortInstructions(spellCodes, spellCodes.Length);
    }
}