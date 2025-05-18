-- criação do índice para saber o cpf do responsável por uma limpeza
CREATE INDEX idx_cpf_limpeza ON limpeza (cpf);

-- criação de índice para saber em qual data uma refeição foi oferecida
CREATE INDEX idx_data_oferece ON oferece (data);

-- criação de índice para saber qual é o tipo da refeição realizada
CREATE INDEX idx_tipo_inclui ON inclui (tipo);

-- índice criado para facilitar junções e extrair datas de refeições
CREATE INDEX idx_inclui_data ON inclui(data);

-- índice para realizar buscas por nome
CREATE INDEX idx_funcionario_nome_sobrenome on funcionario (nome, sobrenome);

-- índice para saber qual funcionário realizou determinada manutenção
CREATE INDEX idx_manutencao_cpf ON manutencao(cpf);

-- índice para saber a qual restaurante um determinado equipamento pertence
CREATE INDEX idx_equipamento_id_restaurante ON equipamento(id_restaurante);

-- índice para identificar em qual restaurante o funcionário trabalha
CREATE INDEX idx_funcionario_id_restaurante ON funcionario (id_restaurante);