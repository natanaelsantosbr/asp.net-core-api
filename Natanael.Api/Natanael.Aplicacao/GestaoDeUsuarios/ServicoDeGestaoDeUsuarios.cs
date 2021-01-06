using Infra.EF;
using Microsoft.IdentityModel.Tokens;
using Natanael.Aplicacao.GestaoDeUsuarios.Modelos;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Natanael.Aplicacao.GestaoDeUsuarios
{
    public class ServicoDeGestaoDeUsuarios : IServicoDeGestaoDeUsuarios
    {
        private IServicoExternoDePersistencia _servicoExternoDePersistencia;

        public ServicoDeGestaoDeUsuarios(IServicoExternoDePersistencia servicoExternoDePersistencia)
        {
            this._servicoExternoDePersistencia = servicoExternoDePersistencia;
        }

        public string GerarToken(ModeloDeLogin modelo)
        {
            var usuario = this._servicoExternoDePersistencia.RepositorioDeUsuarios.BuscarUsuarioPorNomeESenha(modelo.Nome, modelo.Senha);

            var tokenHandler = new JwtSecurityTokenHandler();
            var chave = Encoding.ASCII.GetBytes("VDBzH$lkmE^tTv1tPwL@d*J9NNUNANRT1qDhZ6SD2UjvXv16S");

            var tokenDescricao = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.Nome.ToString()),
                    new Claim(ClaimTypes.Role, usuario.Funcao.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(chave),
                    SecurityAlgorithms.HmacSha256Signature)

            };

            var token = tokenHandler.CreateToken(tokenDescricao);

            return tokenHandler.WriteToken(token);
        }
    }
}
