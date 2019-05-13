using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JH_Staff_Move : MonoBehaviour
{

    public JH_Set_Class.ClassName classTaught;
    private JH_Staff_Manager staffManager;
    private SpriteRenderer sr_staff;
    private NavMeshAgent nv_staff;
    private GameObject go_classManager;
    private GameObject go_timeManager;
    public Vector3 v3_positionOffset;

    // Start is called before the first frame update
    void Start()
    {
        nv_staff = GetComponent<NavMeshAgent>();
        go_classManager = GameObject.Find("ClassDrops");
        go_timeManager = GameObject.Find("Date/TimePanel");

    }

    // Update is called once per frame
    void Update()
    {
        UpdateClass();
    }

    public void SetAppearance()
    {
        sr_staff = GetComponentInChildren<SpriteRenderer>();
        staffManager = GameObject.Find("Game").GetComponent<JH_Staff_Manager>();

        if (classTaught == JH_Set_Class.ClassName.Literature) sr_staff.sprite = staffManager.staffLiterature;
        if (classTaught == JH_Set_Class.ClassName.Advanced_Literature) sr_staff.sprite = staffManager.staffAdvancedLiterature;
        if (classTaught == JH_Set_Class.ClassName.Citizenship) sr_staff.sprite = staffManager.staffCitizenship;
        if (classTaught == JH_Set_Class.ClassName.Advanced_Citizenship) sr_staff.sprite = staffManager.staffAdvancedCitizenship;
        if (classTaught == JH_Set_Class.ClassName.BasicScience) sr_staff.sprite = staffManager.staffBasicScience;
        if (classTaught == JH_Set_Class.ClassName.Psychology) sr_staff.sprite = staffManager.staffPsychology;
        if (classTaught == JH_Set_Class.ClassName.Physiology) sr_staff.sprite = staffManager.staffPhysiology;
        if (classTaught == JH_Set_Class.ClassName.Advanced_Science) sr_staff.sprite = staffManager.staffAdvancedScience;
        if (classTaught == JH_Set_Class.ClassName.Persuasion_Hero) sr_staff.sprite = staffManager.staffPersuasionHero;
        if (classTaught == JH_Set_Class.ClassName.Persuasion_Villain) sr_staff.sprite = staffManager.staffPersuasionVillain;
        if (classTaught == JH_Set_Class.ClassName.Genetics_Hero) sr_staff.sprite = staffManager.staffGeneticsHero;
        if (classTaught == JH_Set_Class.ClassName.Genetics_Villain) sr_staff.sprite = staffManager.staffGeneticsVillain;
        if (classTaught == JH_Set_Class.ClassName.Sport) sr_staff.sprite = staffManager.staffSport;
        if (classTaught == JH_Set_Class.ClassName.Gym) sr_staff.sprite = staffManager.staffGym;
        if (classTaught == JH_Set_Class.ClassName.Advanced_Gym) sr_staff.sprite = staffManager.staffAdvancedGym;
        if (classTaught == JH_Set_Class.ClassName.Meditation) sr_staff.sprite = staffManager.staffMeditation;
        if (classTaught == JH_Set_Class.ClassName.Advanced_Meditation) sr_staff.sprite = staffManager.staffAdvancedMeditation;
        if (classTaught == JH_Set_Class.ClassName.Super101) sr_staff.sprite = staffManager.staffSuper101;
        if (classTaught == JH_Set_Class.ClassName.Super201) sr_staff.sprite = staffManager.staffSuper201;
        if (classTaught == JH_Set_Class.ClassName.Physical_Development) sr_staff.sprite = staffManager.staffPhysicalDevelopment;
        if (classTaught == JH_Set_Class.ClassName.Mental_Development) sr_staff.sprite = staffManager.staffMentalDevelopment;
        if (classTaught == JH_Set_Class.ClassName.Responsible_Power_Management) sr_staff.sprite = staffManager.staffResponsiblePowerManagement;
        if (classTaught == JH_Set_Class.ClassName.Maximising_Power_Potential) sr_staff.sprite = staffManager.staffMaximisingPowerPotential;
    }

    void UpdateClass()
    {
        if (go_timeManager.GetComponent<JH_Time_UI>().in_time >= 6 && go_timeManager.GetComponent<JH_Time_UI>().in_time <= 18)
        {
            if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == classTaught)
            {
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Literature)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_literatureClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Citizenship)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_citizenshipClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.BasicScience)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_scienceClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super101)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_superClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Sport)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_sportsClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Citizenship)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedCitizenship.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Literature)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedLiterature.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Psychology)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_psychology.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physiology)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_physiology.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Science)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedScience.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Hero)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_persuasionHero.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Persuasion_Villain)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_persuasionVillain.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Hero)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_geneticsHero.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Genetics_Villain)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_geneticsVillain.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Gym)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_gymClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Gym)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedGym.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Meditation)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_meditationClass.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Advanced_Meditation)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_advancedMeditation.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Super201)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_super201.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Physical_Development)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_physicalDevelopment.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Mental_Development)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_mentalDevelopment.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Responsible_Power_Management)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_responsiblePowerManagement.transform.position + v3_positionOffset;
                }
                if (go_classManager.GetComponent<JH_Assign_Class>().currentClass == JH_Set_Class.ClassName.Maximising_Power_Potential)
                {
                    nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_maximisingPowerPotential.transform.position + v3_positionOffset;
                }
            }
            else
            {
                nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_canteen.transform.position + v3_positionOffset;
            }
        }
        else
        {
            nv_staff.destination = go_classManager.GetComponent<JH_Assign_Class>().go_homeSpot.transform.position;
        }
    }
}
