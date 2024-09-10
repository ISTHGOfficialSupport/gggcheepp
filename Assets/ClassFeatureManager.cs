using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassFeatureManager : MonoBehaviour {

    public List<GameObject> Containers;
    public List<GameObject> Barbarian;
    public List<GameObject> Bard;
    public List<GameObject> Cleric;
    public List<GameObject> Druid;
    public List<GameObject> Fighter;
    public List<GameObject> Monk;
    public List<GameObject> Paladin;
    public List<GameObject> Ranger;
    public List<GameObject> Rogue;
    public List<GameObject> Sorcerer;
    public List<GameObject> Warlock;
    public List<GameObject> Wizard;
    public List<Button> MoreButtons;
    public Dropdown Class;
    public Dropdown Subclass;
    public Dropdown Level;
    public List<ContentSizeFitter> Fitters;
    bool BarbarianMore;
    bool BardMore;
    bool ClericMore;
    bool DruidMore;
    bool FighterMore;
    bool MonkMore;
    bool PaladinMore;
    bool RangerMore;
    bool RogueMore;
    bool SorcererMore;
    bool WarlockMore;
    bool WizardMore;

    // Use this for initialization
    void Start() {
        UpdateClassFeatures();
    }

    // Update is called once per frame
    void Update() {

    }

    public void UpdateClassFeatures()
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            Containers[i].SetActive(false);
            MoreButtons[i].gameObject.SetActive(false);
        }
        if (Class.captionText.text == "Barbarian")
        {
            UpdateBarbarian();
        }
        else if (Class.captionText.text == "Bard")
        {
            UpdateBard();
        }
        else if (Class.captionText.text == "Cleric")
        {
            UpdateCleric();
        }
        else if (Class.captionText.text == "Druid")
        {
            UpdateDruid();
        }
        else if (Class.captionText.text == "Fighter")
        {
            UpdateFighter();
        }
        else if (Class.captionText.text == "Monk")
        {
            UpdateMonk();
        }
        else if (Class.captionText.text == "Paladin")
        {
            UpdatePaladin();
        }
        else if (Class.captionText.text == "Ranger")
        {
            UpdateRanger();
        }
        else if (Class.captionText.text == "Rogue")
        {
            UpdateRogue();
        }
        else if (Class.captionText.text == "Sorcerer")
        {
            UpdateSorcerer();
        }
        else if (Class.captionText.text == "Warlock")
        {
            UpdateWarlock();
        }
        else if (Class.captionText.text == "Wizard")
        {
            UpdateWizard();
        }
        UpdateFitters();
    }

    public void BarbarianToggleMore()
    {
        if (BarbarianMore)
        {
            BarbarianMore = false;
            MoreButtons[0].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            BarbarianMore = true;
            MoreButtons[0].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateBarbarian();
        UpdateFitters();
    }

    public void BardToggleMore()
    {
        if (BardMore)
        {
            BardMore = false;
            MoreButtons[1].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            BardMore = true;
            MoreButtons[1].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateBard();
        UpdateFitters();
    }

    public void ClericToggleMore()
    {
        if (ClericMore)
        {
            ClericMore = false;
            MoreButtons[2].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            ClericMore = true;
            MoreButtons[2].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateCleric();
        UpdateFitters();
    }

    public void DruidToggleMore()
    {
        if (DruidMore)
        {
            DruidMore = false;
            MoreButtons[3].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            DruidMore = true;
            MoreButtons[3].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateDruid();
        UpdateFitters();
    }

    public void FighterToggleMore()
    {
        if (FighterMore)
        {
            FighterMore = false;
            MoreButtons[4].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            FighterMore = true;
            MoreButtons[4].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateFighter();
        UpdateFitters();
    }

    public void MonkToggleMore()
    {
        if (MonkMore)
        {
            MonkMore = false;
            MoreButtons[5].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            MonkMore = true;
            MoreButtons[5].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateMonk();
        UpdateFitters();
    }

    public void PaladinToggleMore()
    {
        if (PaladinMore)
        {
            PaladinMore = false;
            MoreButtons[6].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            PaladinMore = true;
            MoreButtons[6].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdatePaladin();
        UpdateFitters();
    }

    public void RangerToggleMore()
    {
        if (RangerMore)
        {
            RangerMore = false;
            MoreButtons[7].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            RangerMore = true;
            MoreButtons[7].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateRanger();
        UpdateFitters();
    }

    public void RogueToggleMore()
    {
        if (RogueMore)
        {
            RogueMore = false;
            MoreButtons[8].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            RogueMore = true;
            MoreButtons[8].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateRogue();
        UpdateFitters();
    }

    public void SorcererToggleMore()
    {
        if (SorcererMore)
        {
            SorcererMore = false;
            MoreButtons[9].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            SorcererMore = true;
            MoreButtons[9].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateSorcerer();
        UpdateFitters();
    }

    public void WarlockToggleMore()
    {
        if (WarlockMore)
        {
            WarlockMore = false;
            MoreButtons[10].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            WarlockMore = true;
            MoreButtons[10].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateWarlock();
        UpdateFitters();
    }

    public void WizardToggleMore()
    {
        if (WizardMore)
        {
            WizardMore = false;
            MoreButtons[11].GetComponentInChildren<Text>().text = "Show More";

        }
        else
        {
            WizardMore = true;
            MoreButtons[11].GetComponentInChildren<Text>().text = "Show Less";
        }
        UpdateWizard();
        UpdateFitters();
    }

    public void UpdateBarbarian()
    {
        Containers[0].SetActive(true);
        for (int i = 0; i < Barbarian.Count; i++)
        {
            Barbarian[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[0].gameObject.SetActive(true);
        }
        if (BarbarianMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //RecklessAttack
                Unlocked.Add(1); //DangerSense
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(2); //PrimalPath
                if (Subclass.value == 0)
                {
                    Unlocked.Add(3); //PathoftheBerserker
                    Unlocked.Add(4); //Frenzy
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(5); //PathoftheTotemWarrior
                    Unlocked.Add(6); //SpiritSeeker
                    Unlocked.Add(7); //TotemSpirit
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(8); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(9); //ExtraAttack
                Unlocked.Add(10); //FastMovement
            }
            if (intLevel >= 6)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(11); //MindlessRage
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(12); //AspectoftheBeast
                }
            }
            if (intLevel >= 7)
            {
                Unlocked.Add(13); //FeralInstinct
            }
            if (intLevel >= 9)
            {
                Unlocked.Add(14); //BrutalCritical
            }
            if (intLevel >= 10)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(15); //IntimidatingPresence
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(16); //SpiritWalker
                }
            }
            if (intLevel >= 11)
            {
                Unlocked.Add(17); //RelentlessRage
            }
            if (intLevel >= 14)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(18); //Retaliation
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(19); //TotemicAttunement
                }
            }
            if (intLevel >= 15)
            {
                Unlocked.Add(20); //PersistentRage
            }
            if (intLevel >= 18)
            {
                Unlocked.Add(21); //IndomitableMight
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(22); //PrimalChampion
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Barbarian[Unlocked[i]].SetActive(true);
            }
        }
        UpdateFitters();
    }

    public void UpdateBard()
    {
        Containers[1].SetActive(true);
        for (int i = 0; i < Bard.Count; i++)
        {
            Bard[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[1].gameObject.SetActive(true);
        }
        if (BardMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //JackofAllTrades
                Unlocked.Add(1); //SongofRest
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(2); //BardCollege
                if (Subclass.value == 0)
                {
                    Unlocked.Add(3); //CollegeofLore
                    Unlocked.Add(4); //BonusProficiencies
                    Unlocked.Add(5); //CuttingWords
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(6); //CollegeofValor
                    Unlocked.Add(7); //BonusProficiencies
                    Unlocked.Add(8); //CombatInspiration
                }
                Unlocked.Add(9); //Expertise
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(10); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(11); //FontofInspiration
            }
            if (intLevel >= 6)
            {
                Unlocked.Add(12); //Countercharm
                if (Subclass.value == 0)
                {
                    Unlocked.Add(13); //AdditionalMagicalSecrets
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(14); //ExtraAttack
                }
            }
            if (intLevel >= 10)
            {
                Unlocked.Add(15); //MagicalSecrets

            }
            if (intLevel >= 14)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(16); //PeerlessSkill
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(17); //BattleMagic
                }
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(18); //SuperiorInspiration
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Bard[Unlocked[i]].SetActive(true);
            }
        }
        UpdateFitters();
    }

    public void UpdateCleric()
    {
        Containers[2].SetActive(true);
        for (int i = 0; i < Cleric.Count; i++)
        {
            Cleric[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[2].gameObject.SetActive(true);
        }
        List<int> Unlocked = new List<int>();
        int intLevel = int.Parse(Level.captionText.text);
        if (intLevel >= 1)
        {
            if (Subclass.value == 0)
            {
                Unlocked.Add(0); //KnowledgeDomain
                Unlocked.Add(1); //BlessingsofKnowledge
            }
            else if (Subclass.value == 1)
            {
                Unlocked.Add(2); //LifeDomain
                Unlocked.Add(3); //BonusProficiencies
                Unlocked.Add(4); //DiscipleofLife
            }
            else if (Subclass.value == 2)
            {
                Unlocked.Add(5); //LightDomain
                Unlocked.Add(6); //BonusCantrip
                Unlocked.Add(7); //WardingFlare
            }
            else if (Subclass.value == 3)
            {
                Unlocked.Add(8); //NatureDomain
                Unlocked.Add(9); //AcolyteofNature
                Unlocked.Add(10); //BonusProficiency
            }
            else if (Subclass.value == 4)
            {
                Unlocked.Add(11); //TempestDomain
                Unlocked.Add(12); //WrathoftheStorm
                Unlocked.Add(13); //BonusProficiencies
            }
            else if (Subclass.value == 5)
            {
                Unlocked.Add(14); //TrickeryDomain
                Unlocked.Add(15); //BlessingoftheTrickster
            }
            else if (Subclass.value == 6)
            {
                Unlocked.Add(16); //WarDomain
                Unlocked.Add(17); //WarPriest
                Unlocked.Add(18); //BonusPrificiencies
            }
        }
        if (ClericMore)
        {
            if (intLevel >= 2)
            {
                Unlocked.Add(19); //ChannelDivinity
                Unlocked.Add(20); //TurnUndead
                if (Subclass.value == 0)
                {
                    Unlocked.Add(21); //KnowledgeoftheAges
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(22); //PreserveLife
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(23); //RadianceoftheDawn
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(24); //CharmAnimalsandPlants
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(25); //DestructiceWrath
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(26); //InvokeDuplicity
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(27); //GuidedStrike
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(28); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(29); //DestroyUndead
            }
            if (intLevel >= 6)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(30); //ReadThoughts
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(31); //BlessedHealer
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(32); //ImprovedFlare
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(33); //DampenElements
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(34); //ThunderboltStrike
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(35); //CloakofShadows
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(36); //WarGodsBlessing
                }
            }
            if (intLevel >= 8)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(37); //PotentSpellcasting
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(38); //DivineStrike
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(39); //PotentSpellcasting
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(40); //DivineStrike
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(41); //DivineStrike
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(42); //DivineStrike
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(43); //DivineStrike
                }
            }
            if (intLevel >= 10)
            {
                Unlocked.Add(44); //DivineIntervention
            }
            if (intLevel >= 17)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(45); //VisionsofthePast
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(46); //SupremeHealing
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(47); //CoronaofLight
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(48); //MasterofNature
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(49); //Stormborn
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(50); //ImprovedDuplicity
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(51); //AvatarofBattle
                }
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Cleric[Unlocked[i]].SetActive(true);
            }
        }
        UpdateFitters();
    }

    public void UpdateDruid()
    {
        Containers[3].SetActive(true);
        for (int i = 0; i < Druid.Count; i++)
        {
            Druid[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[3].gameObject.SetActive(true);
        }
        if (DruidMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //WildShape
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(1); //DruidCicle
                Unlocked.Add(2); //DruidCicles
                if (Subclass.value == 0)
                {
                    Unlocked.Add(3); //CircleoftheLand
                    Unlocked.Add(4); //BonusCantrip
                    Unlocked.Add(5); //NaturesRecovery
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(6); //CircleoftheMoon
                    Unlocked.Add(7); //CombatWildShape
                    Unlocked.Add(8); //CircleForms
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(9); //AbilityScoreImprovement
            }
            if (intLevel >= 6)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(13); //LandStride
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(14); //PrimalStrike
                }
            }
            if (intLevel >= 10)
            {
                Unlocked.Add(15); //MagicalSecrets

            }
            if (intLevel >= 14)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(16); //PeerlessSkill
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(17); //BattleMagic
                }
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(18); //SuperiorInspiration
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Druid[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateFighter()
    {
        Containers[4].SetActive(true);
        for (int i = 0; i < Fighter.Count; i++)
        {
            Fighter[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[4].gameObject.SetActive(true);
        }
        if (FighterMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //ActionSurge
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(1); //MartialArchetype
                Unlocked.Add(2); //MartialArchetypes
                if (Subclass.value == 0)
                {
                    Unlocked.Add(3); //BattleMaster
                    Unlocked.Add(4); //Maneuvers
                    Unlocked.Add(5); //StudentofWar
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(6); //Champion
                }
                else if(Subclass.value == 2)
                {
                    Unlocked.Add(7); //EldrichKnight
                    Unlocked.Add(8); //WeaponBond
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(9); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(10); //ExtraAttack
            }
            if (intLevel >= 7)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(11); //KnowYourEnemy
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(12); //RemarkableAthlete
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(13); //WarMagic
                }
            }
            if (intLevel >= 9)
            {
                Unlocked.Add(14); //Indomitable

            }
            if (intLevel >= 10)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(15); //ImproveddCritical
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(16); //AdditionalFightingStyle
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(17); //EldritchStrike
                }
            }
            if (intLevel >= 15)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(18); //Relentless
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(19); //SuperiorCritical
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(20); //ArcaneCharge
                }
            }
            if (intLevel >= 20)
            {
                if (Subclass.value == 1)
                {
                    Unlocked.Add(21); //Survivor
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(22); //ImprovedWarMagic
                }
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Fighter[Unlocked[i]].SetActive(true);
            }
        }
        UpdateFitters();
    }

    public void UpdateMonk()
    {
        Containers[5].SetActive(true);
        for (int i = 0; i < Monk.Count; i++)
        {
            Monk[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[5].gameObject.SetActive(true);
        }
        if (MonkMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //Ki
                Unlocked.Add(1); //UnarmoredMovement
                Unlocked.Add(2); //DeflectMissiles
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(3); //MonasticOrders
                Unlocked.Add(4); //MonasticTradition
                Unlocked.Add(5); //MonasticTraditions
                if (Subclass.value == 0)
                {
                    Unlocked.Add(6); //WayoftheShadow
                    Unlocked.Add(7); //ShadowArts
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(8); //WayoftheFourElements
                    Unlocked.Add(9); //DiscipleoftheElements
                    Unlocked.Add(10); //ElementalDisciple
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(11); //WayoftheOpenHand
                    Unlocked.Add(12); //OpenHandTechnique
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(13); //AbilityScoreImprovement
                Unlocked.Add(14); //SlowFall
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(15); //ExtraAttack
                Unlocked.Add(16); //StunningStrike
            }
            if (intLevel >= 6)
            {
                Unlocked.Add(17); //KiEmpoweredStrike
                if (Subclass.value == 0)
                {
                    Unlocked.Add(18); //ShadowStep
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(19); //WholenessofBody
                }
            }
            if (intLevel >= 7)
            {
                Unlocked.Add(20); //Evasion
                Unlocked.Add(21); //StillnessofMind
            }
            if (intLevel >= 10)
            {
                Unlocked.Add(22); //PurityofBody

            }
            if (intLevel >= 11)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(23); //CloakofShadows
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(24); //Tranquility
                }
            }
            if (intLevel >= 13)
            {
                Unlocked.Add(25); //TounguesoftheSunandMoon

            }
            if (intLevel >= 14)
            {
                Unlocked.Add(26); //DiamondSoul

            }
            if (intLevel >= 15)
            {
                Unlocked.Add(27); //TimelessBody

            }
            if (intLevel >= 17)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(28); //Opportunist
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(29); //QuiveringPalm
                }
            }
            if (intLevel >= 18)
            {
                Unlocked.Add(30); //EmptyBody
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(31); //PerfectSelf
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Monk[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdatePaladin()
    {
        Containers[6].SetActive(true);
        for (int i = 0; i < Paladin.Count; i++)
        {
            Paladin[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[6].gameObject.SetActive(true);
        }
        if (PaladinMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //FightingStyle
                Unlocked.Add(1); //Spellcasting
                Unlocked.Add(2); //DivineSmite
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(3); //DivineHealth
                Unlocked.Add(4); //SacredOath
                Unlocked.Add(5); //SacredOaths
                if (Subclass.value == 0)
                {
                    Unlocked.Add(6); //OathofDevotion
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(7); //OathoftheAncients
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(8); //OathofVengeance
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(9); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(10); //ExtraAttack
            }
            if (intLevel >= 6)
            {
                Unlocked.Add(11); //AuraofProtection
            }
            if (intLevel >= 7)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(12); //AuraofDevotion
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(13); //AuraofWarding
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(14); //RelentlessAvenger
                }
            }
            if (intLevel >= 10)
            {
                Unlocked.Add(15); //AuraofCourage
            }
            if (intLevel >= 11)
            {
                Unlocked.Add(16); //ImprovedDivineSmite
            }
            if (intLevel >= 14)
            {
                Unlocked.Add(17); //CleansingTouch
            }
            if (intLevel >= 15)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(18); //PurityofSpirit
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(19); //UndyingSentinal
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(20); //SoulofVengeance
                }
            }
            if (intLevel >= 20)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(21); //HolyNimbus
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(22); //ElderChampion
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(23); //AvengingAngel
                }
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Paladin[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateRanger()
    {
        Containers[7].SetActive(true);
        for (int i = 0; i < Ranger.Count; i++)
        {
            Ranger[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[7].gameObject.SetActive(true);
        }
        if (RangerMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //FightingStyle
                Unlocked.Add(1); //Spellcasting
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(2); //PrimevelAwereness
                Unlocked.Add(3); //RangerArchetype
                Unlocked.Add(4); //RangerArchetypes
                if (Subclass.value == 0)
                {
                    Unlocked.Add(5); //BeastMaster
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(6); //Hunter
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(7); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(8); //ExtraAttack
            }
            if (intLevel >= 7)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(9); //ExceptionalTraining
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(10); //DefensiveTectics
                }
            }
            if (intLevel >= 8)
            {
                Unlocked.Add(11); //LandStride
            }
            if (intLevel >= 10)
            {
                Unlocked.Add(12); //HideinPlaneSight
            }
            if (intLevel >= 11)
            {

                if (Subclass.value == 0)
                {
                    Unlocked.Add(13); //BestialFury
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(14); //MultiAttack
                }
            }
            if (intLevel >= 14)
            {
                Unlocked.Add(15); //Vanish
            }
            if (intLevel >= 15)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(16); //ShareSpells
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(17); //SuperiorHuntersDefense
                }
            }
            if (intLevel >= 18)
            {
                Unlocked.Add(18); //FeralSenses
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(19); //FoeSlayer
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Ranger[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateRogue()
    {
        Containers[8].SetActive(true);
        for (int i = 0; i < Rogue.Count; i++)
        {
            Rogue[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[8].gameObject.SetActive(true);
        }
        if (RogueMore)
        {
            List<int> Unlocked = new List<int>();
            int intLevel = int.Parse(Level.captionText.text);
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //CunningAction
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(1); //RoguishArcetype
                Unlocked.Add(2); //RoguishArcetypes
                if (Subclass.value == 0)
                {
                    Unlocked.Add(3); //ArcaneTrickster
                    Unlocked.Add(4); //MageHandLegerdemain
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(5); //Assassin
                    Unlocked.Add(6); //Assassinate
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(7); //Thief
                    Unlocked.Add(8); //SecondStoryWork
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(9); //AbilityScoreImprovement
            }
            if (intLevel >= 5)
            {
                Unlocked.Add(10); //UncannyDodge
            }
            if (intLevel >= 7)
            {
                Unlocked.Add(11); //Evasion
            }
            if (intLevel >= 9)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(12); //MagicalAmbush
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(13); //InfiltrationExpert
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(14); //SupremeSneak
                }
            }
            if (intLevel >= 11)
            {
                Unlocked.Add(15); //ReliableTalent
            }
            if (intLevel >= 13)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(16); //VersatileTricks
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(17); //Imposter
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(18); //UseMagicDevices
                }
            }
            if (intLevel >= 14)
            {
                Unlocked.Add(19); //BlindSense
            }
            if (intLevel >= 15)
            {
                Unlocked.Add(20); //SlipperyMind
            }
            if (intLevel >= 17)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(21); //SpellThief
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(22); //DeathStrike
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(23); //ThiefsReflexes
                }
            }
            if (intLevel >= 18)
            {
                Unlocked.Add(24); //Elusive
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(25); //StrokeofLuck
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Rogue[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateSorcerer()
    {
        Containers[9].SetActive(true);
        for (int i = 0; i < Sorcerer.Count; i++)
        {
            Sorcerer[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[9].gameObject.SetActive(true);
        }
        List<int> Unlocked = new List<int>();
        int intLevel = int.Parse(Level.captionText.text);
        if (intLevel >= 1)
        {
            if (Subclass.value == 0)
            {
                Unlocked.Add(0); //DraconicBloodline
            }
            else if (Subclass.value == 1)
            {
                Unlocked.Add(1); //WildMagic
            }
        }
        if (SorcererMore)
        {
            if (intLevel >= 2)
            {
                Unlocked.Add(2); //FontofMagic
                Unlocked.Add(3); //SorceryPoints
                Unlocked.Add(4); //FlexibleCasting
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(5); //Metamagic
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(6); //AbilityScoreImprovement
            }
            if (intLevel >= 6)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(7); //ExceptionalTraining
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(8); //DefensiveTectics
                }
            }
            if (intLevel >= 14)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(9); //ExceptionalTraining
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(10); //DefensiveTectics
                }
            }
            if (intLevel >= 18)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(11); //ExceptionalTraining
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(12); //DefensiveTectics
                }
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(13); //
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Sorcerer[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateWarlock()
    {
        Containers[10].SetActive(true);
        for (int i = 0; i < Warlock.Count; i++)
        {
            Warlock[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[10].gameObject.SetActive(true);
        }
        List<int> Unlocked = new List<int>();
        int intLevel = int.Parse(Level.captionText.text);
        if (intLevel >= 1)
        {
            if (Subclass.value == 0)
            {
                Unlocked.Add(0); //GreatOldOne
            }
            else if (Subclass.value == 1)
            {
                Unlocked.Add(1); //TheArchfey
            }
            else if (Subclass.value == 1)
            {
                Unlocked.Add(2); //TheFiend
            }
        }
        if (WarlockMore)
        {
            if (intLevel >= 2)
            {
                Unlocked.Add(3); //EldrichInvocations
                Unlocked.Add(4); //InvocationList
            }
            if (intLevel >= 3)
            {
                Unlocked.Add(5); //PactBoon
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(6); //AbilityScoreImprovement
            }
            if (intLevel >= 6)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(7); //EnthropicWard
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(8); //MistyEscape
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(9); //DarkOnesOwnLuck
                }
            }
            if (intLevel >= 10)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(10); //ThoughtShield
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(11); //BeguilingDefenses
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(12); //FiendishResilience
                }
            }
            if (intLevel >= 11)
            {
                Unlocked.Add(13); //MysticArcanum
            }
            if (intLevel >= 14)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(14); //CreateThrall
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(15); //DarkDelirium
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(16); //HurlThroughHell
                }
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(17); //EldritchMaster
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Warlock[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateWizard()
    {
        Containers[11].SetActive(true);
        for (int i = 0; i < Wizard.Count; i++)
        {
            Wizard[i].SetActive(false);
        }
        if (int.Parse(Level.captionText.text) >= 2)
        {
            MoreButtons[11].gameObject.SetActive(true);
        }
        List<int> Unlocked = new List<int>();
        int intLevel = int.Parse(Level.captionText.text);
        if (WizardMore)
        {
            if (intLevel >= 2)
            {
                Unlocked.Add(0); //ArcaneTradition
                Unlocked.Add(1); //ArcaneTraditions
                if (Subclass.value == 0)
                {
                    Unlocked.Add(2); //SchoolofAbjuration
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(3); //SchoolofConjuration
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(4); //SchoolofDivination
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(5); //SchoolofEnchantment
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(6); //SchoolofEvocation
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(7); //SchoolofIllusion
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(8); //SchoolofNecromancy
                }
                else if (Subclass.value == 7)
                {
                    Unlocked.Add(9); //SchoolofTransmutation
                }
            }
            if (intLevel >= 4)
            {
                Unlocked.Add(10); //AbilityScoreImprovement
            }
            if (intLevel >= 6)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(11); //ProjectedWard
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(12); //BenignTransportation
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(13); //ExpertDivination
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(14); //InstinctiveCharm
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(15); //PotentCantrip
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(16); //MalleableIllusions
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(17); //UndeadThralls
                }
                else if (Subclass.value == 7)
                {
                    Unlocked.Add(18); //TransmutersStone
                }
            }
            if (intLevel >= 10)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(19); //ImprovedAbjuration
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(20); //FocusedConjuration
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(21); //TheThirdEye
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(22); //SplitEnchantment
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(23); //EmpoweredEvocation
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(24); //IllusorySelf
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(25); //InuredToUndeath
                }
                else if (Subclass.value == 7)
                {
                    Unlocked.Add(26); //ShapeChanger
                }
            }
            if (intLevel >= 14)
            {
                if (Subclass.value == 0)
                {
                    Unlocked.Add(27); //SpellResistance
                }
                else if (Subclass.value == 1)
                {
                    Unlocked.Add(28); //DurableSummons
                }
                else if (Subclass.value == 2)
                {
                    Unlocked.Add(29); //GreaterPortent
                }
                else if (Subclass.value == 3)
                {
                    Unlocked.Add(30); //AlterMemories
                }
                else if (Subclass.value == 4)
                {
                    Unlocked.Add(31); //OverChannel
                }
                else if (Subclass.value == 5)
                {
                    Unlocked.Add(32); //IlluseryReality
                }
                else if (Subclass.value == 6)
                {
                    Unlocked.Add(33); //CommandUndead
                }
                else if (Subclass.value == 7)
                {
                    Unlocked.Add(34); //MasterTransmuter
                }
            }
            if (intLevel >= 18)
            {
                Unlocked.Add(35); //SpellMastery
            }
            if (intLevel >= 20)
            {
                Unlocked.Add(36); //SignatureSpells
            }
            for (int i = 0; i < Unlocked.Count; i++)
            {
                Wizard[Unlocked[i]].SetActive(true);
            }
        }
    }

    public void UpdateFitters()
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            Fitters[i].enabled = true;
            Canvas.ForceUpdateCanvases();
            Fitters[i].enabled = false;
        }
    }
}
