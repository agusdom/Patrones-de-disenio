using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : Monobehaviour,IDamageReceiver{
 [SerializeField] private TextMeshProUGUI[] _damageTexts;
 private int _lastTextUsed;

 private void Awake(){
  foreach(var damageText in _damageTexts){
    damageText.SetText(string.Empty);
  }
 }

 public void ReceiveDamage(){
  var textIndex = GetTextIndexToUse();
  
  _damageTexts[textIndex].SetText(damage.ToString());
  _damageTexts[textIndex].color = color;

  _lastTextUsed = textIndex;
 } 

 private int GetTextIndexToUse(){
  return (_lastTextUsed + 1) % _damageTexts.Length;
 }
}
