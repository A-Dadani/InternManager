using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Linq;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using InternManagerLibrary;
using Microsoft.VisualBasic.Logging;

namespace InternManagerUI
{
	internal class ConvocationDocument : IDocument
	{
		private InternModel _model;
		private QuestPDF.Infrastructure.Image LogoImage = QuestPDF.Infrastructure.Image.FromFile("resources\\OCP_Logo.png");
		private string bodyOpeningText = "Suite à votre demande, nous avons l'honneur de vous faire part de notre accord pour l'organisation d'un stage ouvrier au sein du Groupe OCP.";
		private string bodyClosingText; //Filled in constructor because of civilite
		private string footNote = "OCP S.A.\nSociété anonyme au capital de 8.287.500.000 DH- Registre du commerce de Casablanca n°40327 - Identifiant Fiscal n°02220794- Patente n°360006702 - 4, rue Al Abtal, Hay Erraha, 20 200 Casablanca, Maroc- Téléphone/Standard: +212 (0) 5 22 23 20 25 / +212 (0) 5 22 92 30 00 / +212 (0) 5 22 92 40 00\nwww.ocpgroup.ma";
		private DateTime _currentTime;
		private string civiliteString = "";

		public ConvocationDocument(InternModel model)
		{
			_model = model;
			_currentTime = DateTime.Now;

			switch (_model.civilite)
			{
				case InternModel.Civilite.monsieur:
					civiliteString = "Monsieur"; break;
				case InternModel.Civilite.madame:
					civiliteString = "Madame"; break;
			}

			bodyClosingText = "Veuillez agréer, " + civiliteString + " l'expression de nos sentiments distingués.";
		}

		public DocumentMetadata GetMetadata()
		{
			DocumentMetadata metadata = DocumentMetadata.Default;
			metadata.Title = "Convocation_"
				+ _model.lastName.ToUpper() + "_"
				+ CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_model.firstName.ToLower()) + "_"
				+ _model.CNI;
			return metadata;
		}
		
		public void Compose(IDocumentContainer container)
		{
			container.Page(page =>
			{
				page.Margin(50);
				page.Size(PageSizes.A4);
				page.DefaultTextStyle(x => x.FontSize(10));

				page.Header().Element(ComposeHeader);
				page.Content().Element(ComposeContent);

				page.Footer().AlignLeft().Text(footNote).FontSize(7.5f);
			});
		}

		public void ComposeHeader(IContainer container)
		{
			string receiverFormulation;

			receiverFormulation =
				civiliteString
				+ " " + _model.lastName.ToUpper() + " " + _model.firstName.ToUpper() + "\n"
				+ "N° CNI: " + _model.CNI.ToUpper() + "\n"
				+ _model.schoolName;

			container.Column(column =>
			{
				column.Spacing(15);

				column.Item().Row(row =>
				{
					row.ConstantItem(45).Image(LogoImage);
				});

				column.Item().Row(row =>
				{
					row.RelativeItem();
					row.ConstantItem(200).AlignCenter().Text("Khouribga, le " + _currentTime.ToString("dd/MM/yyyy")).Bold();
				});

				column.Item().Row(row =>
				{
					//TODO: is this a hard coded value?
					row.RelativeItem().AlignLeft().Text("OIK/H N° 359").Bold();
				});

				column.Item().Row(row =>
				{
					row.RelativeItem();
					row.ConstantItem(200).AlignCenter().Text(receiverFormulation).Bold();
				});
			});
		}

		public void ComposeContent(IContainer container)
		{
			int columnSize = 350;
			float innerProportions = 0.5f;
			int interLineSpacing = 4;
			container.PaddingVertical(20).Column(column =>
			{
				column.Item().Row(row =>
				{
					row.RelativeItem().AlignLeft().Text(text =>
					{
						text.Line(civiliteString);
						text.Span("\n").FontSize(5);
						text.Line("        " + bodyOpeningText);
					});
				});

				string internshipPeriod = "du " + _model.startDate.ToString("dd/MM/yyyy") + " au " + _model.endDate.ToString("dd/MM/yyyy");
				string studyYearBranch = string.Empty;

				switch (_model.studyYear)
				{
					case 1:
						studyYearBranch = "1ère année"; break;
					default:
						studyYearBranch = _model.studyYear.ToString() + "ème année"; break;
				}
				studyYearBranch += (", " + _model.studyBranch);

				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "Année d'étude et spécialité"	, studyYearBranch			);
				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "Période de stage"				, internshipPeriod			);
				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "Direction d'accueil"			, _model.directionAccueil	);
				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "Entité d'accueil"				, _model.entiteAccueil		);
				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "Parrain de stage"				, _model.parrain			);
				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "Conditions générales"			, null						);

				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "- Hébergement et restauration", "à la charge des stagiaires" , true);
				CreateInformationRow(column, columnSize, innerProportions, interLineSpacing, "- Assurance"					, "Les stagiaires doivent être assurés par leurs soins ou leur école contre les risques encourus durant leur séjour au sein du Groupe OCP (accident de travail, de trajet, maladie, ...).", true);

				column.Item().Row(row =>
				{
					row.RelativeItem().AlignLeft().Text(text =>
					{
						text.Span("").FontSize(5);
						text.Line("        " + bodyClosingText);
					});
				}); 
				
				column.Item().Row(row =>
				{
					row.RelativeItem();
					row.ConstantItem(200).AlignCenter().Text("Le Directeur Capital Humain\nSite de Khouribga").Bold(); ;
				});
			});
		}

		private void CreateInformationRow(
			ColumnDescriptor column, 
			int columnSize, 
			float innerProportions, 
			int interLineSpacing, 
			string lhs, 
			string? rhs,
			bool islhsLight = false) 
		{
			int lhsSize = (int)(columnSize * innerProportions);
			int rhsSize = columnSize - lhsSize;
			column.Item().Row(row =>
			{
				row.RelativeItem();
				row.ConstantItem(columnSize).AlignCenter().Row(row =>
				{
					row.ConstantItem(lhsSize - 8).Column(column =>
					{
						column.Item().Text(text =>
						{
							if (islhsLight)
							{
								text.Line(lhs);
							}
							else
							{
								text.Line(lhs).Bold();
							}
							text.Span("\n").FontSize(interLineSpacing);
						});
					});

					row.ConstantItem(8).Column(column =>
					{
						if (rhs != null)
						{
							column.Item().Text(":").Bold();
						}
					});

					row.ConstantItem(rhsSize).Column(column =>
					{
						if (rhs != null)
						{
							column.Item().Text(text =>
							{
								text.Span(rhs);
								text.Line("").FontSize(interLineSpacing);
							});
						}
					});
				});
				row.RelativeItem();
			});
		}
	}
}
