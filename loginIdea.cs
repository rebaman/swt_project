using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginIdea
{
    // Make sure that after clicking to login button the system checks
    // users Access rights.
    // The last two digits of the staff id determines the access rights
    // Last 2 digit --> 00:= Supervisor/Manager 01:=Human Ressources 02:= Employee

    // Button pressed

    void isLoginValid(){
        string idFromUser = _credentials.Text;
        if(acceptedIDFormat(idFromUser)){
            int idUser = Int64.Parse(idFromUser);
            // Company name = ResearchInstitute 
            bool employeeWithTheIDExist = ResearchInstitute.employee_list.find(idUser);
            if (employeeWithTheIDExist) {
                string passwordGivenFromUser = textBox_password.Text;
                string realPassword = ResearchInstitute.employee_list[ResearchInstitute.employee_list.IndexOf(idUser)].passwort;
                if(passwordGivenFromUser == realPassword){
                    if(idUser % 100 == 0){
                        // Pop-up Window Manager
                    }
                    else if(idUser % 100 == 1){
                        // Pop-up Human Ressources
                    }
                    else(idUser % 100 == 2){
                        // Pop-up Window Employee
                    }
                }
            }
            // Employee with the given ID does not exist
            else {
                // Pop-up Window Error, no employee with the given ID
            }
        }
    }

    

    // give the _credentials as input, ID can only contain numbers
    bool acceptedIDFormat(const char *str) {
        while(*str != '\0'){
            if(*str < '0' || *str > '9')
                return false;
            str++;
        }
    return true;
    }
}
