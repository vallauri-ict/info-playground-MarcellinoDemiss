﻿--CREATE TRIGGER AggiornamentoCampi
--	ON [dbo].[Driver]
--	AFTER UPDATE
--	AS
--	BEGIN
--		IF NEW.number <> OLD.number
--			INSERT INTO StoricoAggiornamentiCampi(NomeCampo, ValoreCampoOld, ValoreCampoNew)
--				VALUES(number, NEW.number, OLD.number);
--	END;