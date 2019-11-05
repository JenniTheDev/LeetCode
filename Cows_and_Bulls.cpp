class Solution {
public:
    string getHint(string secret, string guess) {
        int cows = 0 ;
        int bulls = 0; 
        
        for (int i = 0; i < secret.length(); i++){
            if (secret[i] == guess[i]){
                bulls++;
                secret[i] = ' ';
            }
        }   
         for (int i = 0; i < secret.length(); i++){
                for (int j = 0; j < secret.length(); j++){
                    if (secret[i]==guess[j]){
                        cows++;
                    }
                }            
         }       
      return (to_string(bulls) + "A" + to_string(cows) + "B") ; 
    }    
    
};
