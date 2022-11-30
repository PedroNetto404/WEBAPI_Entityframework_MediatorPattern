﻿using BkVirtual.Core.NotificationError;

namespace BkVirtual.Core.DTOs;

public record BaseResponse
{
    public bool Status { get; set; }
    public object? Resultado { get; set; }
    public IEnumerable<NotificacaoErro>? Erros { get; set; }

    public void AdicionarErros(IEnumerable<NotificacaoErro> erros)
    {
        Erros = erros;
    }

    public static BaseResponse Erro(IEnumerable<NotificacaoErro>? erros = null)
    {
        return new BaseResponse()
        {
            Erros = erros,
            Status = false
        };
    }

    public static BaseResponse Sucesso(object? resultado = null)
    {
        return new BaseResponse()
        {
            Resultado = resultado,
            Status = true
        };
    }
}