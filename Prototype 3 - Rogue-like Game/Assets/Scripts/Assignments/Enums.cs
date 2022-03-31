using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enums : MonoBehaviour
{
    enum Color {blue, red, yellow, green, orange, purple};

    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge};

    enum CarModel {Alero, Cruze, Mustang, Miata, Tacoma, Viper};

    enum WeaponClass {Megalance, Greataxe, EtherCannon, KnuckleClaws, BitBall, TwinRings, ShieldHammer, ChromaKatana};

    enum PolyhedralDice {d4, d6, d8, d10, d12, d20};

    enum CharacterClasses {Barbarian, Bard, Cleric, Druid, Fighter, Monk, Ranger, Rogue, Sorcerer, Warlock, Wizard};

    enum Titans {Argentum, Gormott, Uraya, MorArdain, Indol, Temperantia, Tantal};

    enum Pasta {Macaroni, Fettuccine, Spaghetti, Penne};

    enum Place{};

    enum Holder {};

    // Start is called before the first frame update
    void Start()
    {
       /* Color paint;
       paint = Color.blue;

       print(paint); 
        */

       CarMake make;

       CarModel model;

       make = CarMake.Dodge;
       model = CarModel.Viper;

       //print("Car Manufacturer: " + make + " Model: " + model);

       Recall(CarMake.Mazda, CarModel.Miata);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Oldsmobile && model == CarModel.Alero)
        {
            print("There is a recall on your vehicle due to a faulty ignition, please take your car to the nearest dealer for repairs.");
        }
        else if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall on all Mustangs for being too cool to drive!");
        }
        else
        {
            print("There is no recall notice for your vehicle make and model.");
        }
    }


}
