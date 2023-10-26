# Configuration file for the Sphinx documentation builder.
#
# For the full list of built-in configuration values, see the documentation:
# https://www.sphinx-doc.org/en/master/usage/configuration.html

# -- Project information -----------------------------------------------------
# https://www.sphinx-doc.org/en/master/usage/configuration.html#project-information

project = 'Food Fight'
author = 'Error Makers'
release = '0.1'
# These are options specifically for the Wagtail Theme.
html_theme_options = dict(
    project_name = project,
    logo = "img/wagtail-logo-new.svg",
    logo_alt = "Wagtail",
    logo_height = 59,
    logo_url = "/",
    logo_width = 45,
)

# -- General configuration ---------------------------------------------------
# https://www.sphinx-doc.org/en/master/usage/configuration.html#general-configuration

extensions = [
	"sphinx.ext.duration",
  "sphinxsharp.sphinxsharp",
	"sphinx_wagtail_theme",
]
html_last_updated_fmt = "%I:%M %p %d %b %Y"
templates_path = ['_templates']
exclude_patterns = []



# -- Options for HTML output -------------------------------------------------
# https://www.sphinx-doc.org/en/master/usage/configuration.html#options-for-html-output

html_theme = 'sphinx_wagtail_theme'
html_static_path = ['_static']
