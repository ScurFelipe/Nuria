SELECT * FROM Atendimento a WHERE a.cd_especialidade = 'Neurologia'
JOIN Pacientes p ON a.id_paciente = p.id_paciente
JOIN Prontuario pr ON a.id_prontuario = pr.id_prontuario
JOIN Unidade u ON pr.nome_unidade = u.nome_unidade
JOIN Especialidade e ON u.cd_especialidade = e.cd_especialidade
WHERE p.nome_paciente = 'NomeDoPaciente'
AND e.descricao_especialidade = 'Neurologia'
AND a.data_atendimento >= DATE_SUB(CURRENT_DATE, INTERVAL 6 MONTH);