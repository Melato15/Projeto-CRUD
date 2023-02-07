class ContaPoupanca : Conta{
    // ganha 2% de juros ao fim do mês, com base no saldo da conta


    public ContaPoupanca(string tit, decimal val) : base(tit,val){

    }



    public override void fecharMes(){
        decimal jurosGanhos=0;
        if ( this.saldo > 0 ){
            jurosGanhos = this.saldo * 0.02m;
            this.fazerDeposito(jurosGanhos,DateTime.Now,"Juros de poupança");
        }
    }
}