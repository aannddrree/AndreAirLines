using Model;
using System;
using System.Text;

namespace Data
{
    public class PassegerDB
    {

        #region Atributos

        private DB conexao;

        #endregion

        #region Inserir

        public void InsertPassenger(Passenger passenger)
        {
            StringBuilder sbP = new StringBuilder();

            int idAddress = InsertAddress(passenger.Address);

            sbP.Append("INSERT INTO TB_PASSENGER (Cpf, Name, Telephone, DateBirth, Email, IdAddress) VALUES ");
            sbP.Append(string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", passenger.Cpf, passenger.Name, passenger.Telephone, passenger.DateBirth, passenger.Email, idAddress));

            using (conexao = new DB())
            {
                conexao.ExecutaComando(sbP.ToString());
            }
        }

        private int InsertAddress(Address address)
        {
            StringBuilder sbA = new StringBuilder();

            sbA.Append("INSERT INTO TB_ADDRESS (District, Cidy, Country, CEP, Street, State, Number, Complement) output INSERTED.ID VALUES ");
            sbA.Append(string.Format("('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", address.District, address.Cidy,address.Country, address.CEP, address.Street, address.State, address.Number, address.Complement));

            using (conexao = new DB())
            {
                return conexao.ExecutaComandoScalar(sbA.ToString());
            }
        }

        #endregion
    }
}
