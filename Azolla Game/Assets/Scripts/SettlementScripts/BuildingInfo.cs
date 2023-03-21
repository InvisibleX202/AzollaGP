﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.SettlementScripts
{
    class BuildingInfo
    {
        // class vars
        public string Name { get; set; }
        public string BenOne { get; set; }
        public string BenTwo { get; set; }
        public string Info { get; set; }
        public int MatCost { get; set; }
        public int TimeCost { get; set; }

        public string BenOneUP { get; set; }
        public string BenTwoUP { get; set; }
        public int MatCostUP { get; set; }
        public int TimeCostUP { get; set; }

        public bool IsAvailable { get; set; }
        public int Level { get; set; }

        /// <summary>
        /// Constructor for building class
        /// </summary>
        /// <param name="type">1=Watchtower, 2=Park, 3=AirPurifier</param>
        public BuildingInfo(int type)
        {
            switch (type)
            {
                case 1:
                    makeScienceLab();
                    break;
                case 2:
                    makeTreePlantingZone();
                    break;
                case 3:
                    makeSolarArray();
                    break;
                case 4:
                    makeUniversity();
                    break;
                case 5:
                    makeRecreationCentre();
                    break;
                case 6:
                    makeWindTurbine();
                    break;
                case 7:
                    makeObservatory();
                    break;
                case 8:
                    makeGym();
                    break;
                case 9:
                    makeRecyclingCentre();
                    break;
            }
        }

        // Tier One Buildings -----------------------------------------------------------------------------------------------------------------------

        private void makeScienceLab()
        {
            Name = "Science Lab";
            BenOne = "Provides a boost to the settlements Science score.";
            BenTwo = "Science score can't be reduced below 25%";
            Info = "The Science Lab allows settlers to research new technologies for the advancement of the settlement.";
            MatCost = 250;
            TimeCost = 2;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "Provides a further boost to Science score.";
            BenTwoUP = "Science score can't be reduced below 50%";
            MatCostUP = 300;
            TimeCostUP = 3;
        }

        private void makeTreePlantingZone()
        {
            Name = "Tree Planting Zone";
            BenOne = "Provides a boost to the settlements Morale score.";
            BenTwo = "Morale score can't be reduced below 25%";
            Info = "The Tree Planting Zone provides a recreational area for settlers to unwind and relax, happy settlers are productive settlers.";
            MatCost = 250;
            TimeCost = 2;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "Provides a further boost to Morale score.";
            BenTwoUP = "Morale score can't be reduced below 50%";
            MatCostUP = 300;
            TimeCostUP = 2;
        }

        private void makeSolarArray()
        {
            Name = "Solar Array";
            BenOne = "Provides a boost to the settlements environment score.";
            BenTwo = "Environment score can't be reduced below 25%";
            Info = "Solar Arrays help settlements generate clean energy from the sun, they are an essential step in the mission to resettle earth and build a sustainable society. ";
            MatCost = 250;
            TimeCost = 2;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "Provides a further boost to Environment score.";
            BenTwoUP = "Environment score can't be reduced below 50%";
            MatCostUP = 300;
            TimeCostUP = 2;
        }

        // Tier Two Buildings -----------------------------------------------------------------------------------------------------------------------

        private void makeUniversity() // image tagged as sustainability school
        {
            Name = "University";
            BenOne = "Better conversion value for science score.";
            BenTwo = "1 material = 2 science";
            Info = "The University offers training and development opportunities for settlers. Courses are provided free of charge to all settlers with a thirst for knowledge.";
            MatCost = 150;
            TimeCost = 2;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "Better conversion value for science score.";
            BenTwoUP = "1 material = 3 science";
            MatCostUP = 300;
            TimeCostUP = 3;
        }

        private void makeRecreationCentre() // image tagged as jetpack plant
        {
            Name = "Recreation Centre";
            BenOne = "Better conversion value for morale score.";
            BenTwo = "1 material = 2 morale";
            Info = "The Recreation Centre is a multi-purpose space in which settlers can pursue hobbies and activities in their spare time.";
            MatCost = 150;
            TimeCost = 2;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "Better conversion value for morale score.";
            BenTwoUP = "1 material = 3 morale";
            MatCostUP = 300;
            TimeCostUP = 3;
        }

        private void makeWindTurbine()
        {
            Name = "Wind Turbine";
            BenOne = "Better conversion value for environment score.";
            BenTwo = "1 material = 2 environment";
            Info = "Wind Turbines help settlements generate clean energy from wind, they are an essential step in the mission to resettle earth and build a sustainable society. ";
            MatCost = 150;
            TimeCost = 2;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "Better conversion value for environment score.";
            BenTwoUP = "1 material = 3 environment";
            MatCostUP = 300;
            TimeCostUP = 3;
        }

        // Tier Three Buildings -----------------------------------------------------------------------------------------------------------------------

        private void makeObservatory() // image tagged as monitoring station
        {
            Name = "Observatory";
            BenOne = "Provides a boost to the settlements science score.";
            BenTwo = "Unlock 'Double Jump' Ability";
            Info = "The Observatory acts as a facility for settlers to conduct important interstellar research. it also houses interstellar communications tech to aid in maintaining interplanetary diplomatic relations.";
            MatCost = 500;
            TimeCost = 3;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "No Up-Grade";
            BenTwoUP = "";
            MatCostUP = 0;
            TimeCostUP = 0;
        }

        private void makeGym() // use recycling centre image
        {
            Name = "Gym";
            BenOne = "Provides a boost to the settlements morale score.";
            BenTwo = "Unlock 'Dash' Ability";
            Info = "The Gym gives settlers access to advanced facilities to help maintain good health & fitness.";
            MatCost = 500;
            TimeCost = 3;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "No Up-Grade";
            BenTwoUP = "";
            MatCostUP = 0;
            TimeCostUP = 0;
        }

        private void makeRecyclingCentre() // use high-tech plant image
        {
            Name = "Recycling Facility";
            BenOne = "Provides a boost to the settlements environment score.";
            BenTwo = "Unlock 'Faster Run Speed' Ability";
            Info = "The recycling facility is hi-tech facility equiped with the means to process the settlements waste products. Reduce, Reuse, Recycle!";
            MatCost = 500;
            TimeCost = 3;
            IsAvailable = true;
            Level = 0;

            BenOneUP = "No Up-Grade";
            BenTwoUP = "";
            MatCostUP = 0;
            TimeCostUP = 0;
        }
    }
}
