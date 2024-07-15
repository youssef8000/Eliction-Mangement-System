1. Introduction
   
The Election Management System can help those who want to nominate himself in elections or vote for specific candidate in a simplified way.
If they (voter / candidate) have an account in advance, both voters and candidates will log in. If they do not have an account, they will create one , then enter and start using the system .
If he is a candidate, he will nominate himself by filling out a nomination application, and his data will be reviewed and Verify it.
If approved or rejected, he will receive a response.
On the other hand, it will help citizens to search about specific candidate and vote for him without going anywhere,
the system will collect votes and announce the results later for voter and candidate.

----------------------------------------------------------------------------------------------
2. User Requirements:
   
1- Both voter and candidate (as a user) can create an account or login if they already have an account

2- As a candidate can easily nominate himself by filling out a nomination application

3- The system will review the data of candidate and send to him if it's rejected or approved (Admin)

4- As a Voter can search and choose the candidate he want to vote to

5- System will collect votes of each candidate and then announce the result for voter and candidate
   
----------------------------------------------------------------------------------------------
3. Functional Requirements

1-Registration (log in/ sign up) :
Brief Description : Voter and candidate enter their username and password if they have an account to log in and the Voter and canddon’t have an Account on the system they should sign up by new account.
Inputs :information of voter and candidate
Source: All users .
Pre-Condition: The user opens login page , User should enter username and password.
Post_Condition : The user ready to use the system.
Output: None.

2-View result :
Brief Description: Users ( Voter and candidate) view election results
Input : enter the name of candidate you want to know his result
Source : voter \ candidate
Pre-Condition: none
Post-Condition : The system shows the result
Output : final result

3-Vote
Brief Description : This explains the voting process.
Inputs : Voter should enter candidate name.
Source : the person who wants to vote (Voter).
Pre-Condition: Voter should log in to the vote and search about specific candidate.
Post-Condition : If voting operation verified , Success message display and send success to voter.
Output : message confirming the vote.

4-View Candidate Profile (optional)
Brief Description: this function can show the personal account of the candidate if the voter wanted it , but it is not essential in voting process
Input : Candidate name
Source: Voter
Pre-Condition : none
Post-Condition : none
Output : Personal account of candidate

5- Search For Candidate
Brief Description : The voter needs to look up the name of the candidate he wants to elect and his personal account(if he/she want to explore it).
Inputs : he/she should enter the name of the candidate.
Source : Voter
Pre-Condition : show the searched candidate.
Post-Condition : vote for the chosen candidate
Output : searched candidate.

6- Manage Eliction
Brief Description : Election management includes the ability to create and manage elections, including times and election details.
Input : The managed election would include the necessary information to create the election, such as election details, times, and resources to register candidates
Source : Admin and Candidate
Pre-Condition: The managed election will include all information necessary to create elections, such as election details and times.
Post-Condition : The managed election would include the successful completion of the election, with all votes cast and the results securely stored
Output: The managed elections will include election results, in addition, to reports about the result

----------------------------------------------------------------------------------------------
4. Non Functional Requirements
   
1- Scalability : The system must able to expand for future requirements.

2- Flexibility : The system should cope with other technologies without any hesitation.

3- Mobility : Ability of the system to provide a way to cast their votes without any restriction of the location.

4- Security : Votes should not be manipulated during the voting process.

5- Reliability : Election systems should work robustly, without loss of any votes.

6- Response time : vote process should be fast and refresh screen fast .

7- Usability : The system should be easy to use by voter staff and should be organized in such a way that user errors are minimized.

