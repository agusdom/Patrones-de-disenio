using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHero{
  event Action<int> OnHealthUpdated;

}