$(document).ready(function () {
    $('#btnAdicionar').on("click", function () {
        $.ajax({
            url: "/Aluno/Adicionar",
            method: "POST",
            contentType: "application/json",
            dataType: "json",
            data: JSON.stringify({
                alunoDTO: {
                    nome: $('#nomeAluno').val(),
                    telefone: $('#TelAluno').val(),
                    CPF: $('#CPFAluno').val(),
                    email: $('#emailAluno').val()
                }
            }),
            success: function (result) {
                if (result.success)
                    alert("Salvo com sucesso!");
                else
                    alert("Erro encontrado:" + result.erro);
            }
        });
    });

    $('#btnPesquisar').on("click", function () {
        $.ajax({
            url: "/Aluno/Pesquisar",
            method: "POST",
            contentType: "application/json",
            dataType: "json",
            data: JSON.stringify({
                alunoDTO: {
                    nome: $('#nomeAluno').val(),
                    telefone: $('#TelAluno').val(),
                    CPF: $('#CPFAluno').val(),
                    email: $('#emailAluno').val()
                }
            }),
            success: function (result) {
                $('#tblResultAluno tbody tr').remove();
                if (result.length > 0)
                    result.forEach(function (objAluno) {

                        $('#tblResultAluno tbody').append('<tr>' +
                            '<td>' +
                            objAluno.nome +
                            objAluno.nome +
                            '</td>' +
                            '</tr> ');
                    });
                else
                    $('#tblResultAluno tbody').append('<tr>' +
                        '<td>' +
                        'Sem resultados para a pesquisa.' +
                        '</td>' +
                        '</tr> ');
            }
        });
    });

    $('#btnNovo').on("click", function () {
        window.location.href = "/Aluno/Novo";
    });
    $('#btnVoltar').on("click", function () {
        window.location.href = "/Aluno/Index";
    });
});