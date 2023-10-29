# Configuration file for Sphinx documentation
import os
import sys
sys.path.insert(0, os.path.abspath('.'))

# Project information
project = 'Your Project Name'
copyright = 'Copyright © 2023, Your Name'

# General configuration
extensions = [
    'sphinx.ext.autodoc',
    'sphinx.ext.viewcode',
]

# HTML theme
html_theme = 'sphinx_rtd_theme'  # Use the Read the Docs theme or choose another theme

# Add custom CSS styles or JavaScript (if needed)
html_static_path = ['_static']
html_css_files = ['custom.css']
html_js_files = ['custom.js']