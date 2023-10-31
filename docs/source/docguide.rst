Documentation Guide
===================
Once changes are pushed to the main branch, the documentation will be automatically
build at `food-fight.readthedocs.io`_. 

.. _food-fight.readthedocs.io: https://food-fight.readthedocs.io

To add documentation to this project and observe draft changes, you will 
need to make a virtual environment and build the documentation on your machine.

How to Add Documentation
------------------------
To create a virtual environment, ensure you are in the root directory of the
project. Upgrade the pip package, install the virtual environment package and
create the virtual environment. The *.gitignore* file will ignore your virtual
environment so it is not pushed to the branch.

.. note::
   When using Windows, your python command could either be *python* or *py*. 

.. code-block::
      
       python -m pip install --upgrade pip
       python -m pip install --user virtualenv
       python -m venv env

.. code-block::
      
       py -m pip install --upgrade pip
       py -m pip install --user virtualenv
       py -m venv env

Next, you need to activate the environment. I would recommend using PowerShell
to activate the virtual environment.

.. code-block::

      .\env\Scripts\activate

Now, you need to install Sphinx. Sphinx is a tool that creates documentation using
the reStructuredText markup language. Install Sphinx in your virutal environment.
Next, you need to install the Sphinx extensions used to make the documentation.

.. code-block::

      (env) pip install -U sphinx
      (env) sphinx-build --version
      (env) pip install -r requirements.txt

Next, all you need to do is build the existing documentation on your machine.
Navigate to the *<project-root>/docs* directory. Execute the following command to
build the HTML documentation.

.. code-block::

      (env) .\make.bat html

Now, navigate to the *.../docs/build/* directory and open the *index.html* in your 
browser. It should display the project's documentation.

To make changes to the documentation you need to modify the individual files in
*.../docs/source/*. The files are .rst (reStructuredText) files. For example, the 
home page is the *index.rst* file while this page is the *docguide.rst* file. Please
reference the existing documentation and this `syntax guide`_ for editing the documentation.

.. _syntax guide: https://www.sphinx-doc.org/en/master/usage/restructuredtext/index.html

To write C# code blocks, reference this `csharp guide`_.

.. _csharp guide: https://sphinxsharp-docs.readthedocs.io/en/latest/

.. note::
   When developing the documentation, there is a bug where light/dark mode 
   inconsistency exists. If you switch one page to a specific mode from the 
   default mode, the rest of the pages will still remain in the default mode.
   You can switch the theme on every page for consistency or deal with the 
   inconsistency until the documentation is built. The bug disappears
   once the documentation is built.

.. note::
   Once you have completed the feature implementation and documentation, please update
   the changelog according to the existing format (your user, user story/ major task 
   description, and pull request in each bullet point). 