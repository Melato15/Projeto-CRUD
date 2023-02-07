class ContaMesada : Conta
{
    // um novo deposito automatico de valor fixo a cada mês será realizado
    private decimal valorMesada = 0;


    public ContaMesada(string tit, decimal val, decimal vlm=100) : base(tit,val)  => this.valorMesada = vlm;

    /*
    public ContaMesada(string tit, decimal val, decimal vlm=100) : base(tit,val) 
    {
        this.valorMesada = vlm;
    }
    */



    public override void fecharMes() {
        this.fazerDeposito(this.valorMesada,DateTime.Now,"Deposito de mesada");
    }

}