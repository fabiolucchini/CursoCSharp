USE [Escola01]
GO

/****** Object:  Table [dbo].[Estudantes]    Script Date: 10/6/2022 5:22:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estudantes](
	[EstudanteId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_Estudantes] PRIMARY KEY CLUSTERED 
(
	[EstudanteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



/****** Object:  Table [dbo].[Enderecos]    Script Date: 10/6/2022 5:20:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Enderecos](
	[EnderecoId] [int] IDENTITY(1,1) NOT NULL,
	[Logradouro] [nvarchar](max) NULL,
	[Complemento] [nvarchar](max) NULL,
	[Cidade] [nvarchar](max) NULL,
	[Cep] [int] NOT NULL,
	[Estado] [nvarchar](max) NULL,
	[Pais] [nvarchar](max) NULL,
	[EstudanteId] [int] NOT NULL,
 CONSTRAINT [PK_Enderecos] PRIMARY KEY CLUSTERED 
(
	[EnderecoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_Enderecos_Estudantes_EstudanteId] FOREIGN KEY([EstudanteId])
REFERENCES [dbo].[Estudantes] ([EstudanteId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_Enderecos_Estudantes_EstudanteId]
GO


