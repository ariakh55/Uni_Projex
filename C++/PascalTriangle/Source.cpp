#include <iostream>

using namespace std;

//Using the Binominal Coeff formula we can get the numerical coefficient
int binominalCoeff(int n, int k){
    int res = 1;
    if(k > n - k)
        k = n - k;
    for(int i = 0; i < k; i++){
        res *= (n - i);
        res /= (i + 1);
    }
    return res;

}

int main(){
    int len; 
    cout << "Enter the Length: ";
    cin >> len; //Determining the length
    for(int line = 0; line <= len; line++){
        for(int i = 0; i <= line; i++)
            cout<<binominalCoeff(line , i)<<" ";
        cout<<endl;
    }
    return 0;
}