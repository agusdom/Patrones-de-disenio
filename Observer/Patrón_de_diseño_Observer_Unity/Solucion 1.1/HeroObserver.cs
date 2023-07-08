using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface HeroObserver{
  void Update(IHero subject);
}