using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTest
{
    [Test]
    [TestCase(0)]
    [TestCase(-29)]

    public void DisableOnDeath_EmptyHP_ObjectSetInactive(float hp)
    {
        GameObject testObject = MakeFakePlayer(hp);

        Assert.IsFalse(testObject.activeSelf);
    }

    [Test]
    [TestCase(1)]
    [TestCase(0.6f)]
    [TestCase(100)]
    [TestCase(999999)]
    public void DisableOnDeath_HasHP_ObjectRemainsActive(float hp)
    {
        GameObject testObject = MakeFakePlayer(hp);

        Assert.IsTrue(testObject.activeSelf);
    }

    private static GameObject MakeFakePlayer(float hp)
    {
        GameObject testObject = new GameObject();
        PlayerController playerControllerScript = testObject.AddComponent<PlayerController>();
         
        playerControllerScript.health = hp;
        playerControllerScript.DisableOnDeath();
        return testObject;
    }
}
