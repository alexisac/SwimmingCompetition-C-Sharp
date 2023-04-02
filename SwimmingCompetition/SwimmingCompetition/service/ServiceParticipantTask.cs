using SwimmingCompetition.domain;
using SwimmingCompetition.repository;

namespace SwimmingCompetition.service;

public class ServiceParticipantTask
{
    private RepoBDParticipantTask rpt;


    public ServiceParticipantTask(RepoBDParticipantTask rpt) {
        this.rpt = rpt;
    }


    private int giveNewId()
    {
        List<int> vect = new List<int>();
        foreach (ParticipantTask a in rpt.findAll()){
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
    
    public List<ParticipantTask> findAllParticipants(int idTask){
        return rpt.findAllParticipants(idTask);
    }

    public List<ParticipantTask> findAllTasks(int idParticipant){
        return rpt.findAllTasks(idParticipant);
    }
    
    public void add(int idPArticipant, int idTask){
        ParticipantTask pt = new ParticipantTask(idPArticipant, idTask);
        if(!rpt.ifExist(pt)){
            pt.id = giveNewId();
            rpt.add(pt);
        } else {
            throw new ServiceException("This participant particip at this task already");
        }
    }

}