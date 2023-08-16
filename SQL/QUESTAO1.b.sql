SELECT p.nome_paciente, pr.descricao_prontuario, a.data_atendimento
FROM Pacientes p
JOIN Prontuario pr ON p.id_paciente = pr.id_paciente
JOIN Atendimento a ON pr.id_atendimento = a.id_atendimento
WHERE p.id_paciente = 123;