using SwimmingCompetition.domain;
using SwimmingCompetition.repository;

namespace SwimmingCompetition.service;

public class ServiceParticipant
{
    private RepoBDParticipant rp;
    private Validate v;


    public ServiceParticipant(RepoBDParticipant rp, Validate v) {
        this.rp = rp;
        this.v = v;
    }


    private int giveNewId()
    {
        List<int> vect = new List<int>();
        foreach (Participant a in rp.findAll()){
            vect.Add(a.id);
        }
        vect.Sort();
        bool gasit = false;
        int id = 1;
        int i = 0;
        while (!gasit && i < vect.Count){
            if (id == vect[i]){
                i++;
                id++;
            }
            else
            {
                gasit = true;
            }
        }
        return id;
    }

    public int ifExistParticipant(String name, int age)
    {
        return rp.ifExistParticipant(new Participant(name, age));
    }

    public void add(String name, int age){ 
        if (rp.ifExistParticipant(new Participant(name, age)) == -1) {
            if (v.validateName(name) && v.validateAge(age)) {
                Participant p = new Participant(name, age);
                p.id = giveNewId();
                rp.add(p);
            } else if (!v.validateName(name) && !v.validateAge(age)) {
                throw new ServiceException("Name and age are wrong!");
            } else if (!v.validateName(name)) {
                throw new ServiceException("Name is wrong!");
            } else {
                throw new ServiceException("Age is wrong!");
            }
        } else {
            throw new ServiceException("This participant already exist");
        }
    }
    
    public void delete(int id){
        rp.delete(id);
    }

    public Participant findOne(int idParticipant){
        return rp.findOne(idParticipant);
    }

    public List<Participant> findAll(){
        return rp.findAll();
    }
}