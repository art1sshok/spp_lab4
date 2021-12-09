using System;
using TestGenerator.Interfaces;

namespace TestGenerator
{
    public class NUnitTestGeneratorBuilder : ITestGeneratorBuilder
    {
        private int _maxReadFiles = TestGeneratorBuilderConstants.DefaultMaxReadFiles;

        private int _maxGenerateFiles = TestGeneratorBuilderConstants.DefaultMaxGenerateFiles;

        private int _maxWriteFiles = TestGeneratorBuilderConstants.DefaultMaxWriteFiles;

        public int MaxReadFiles
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxReadFiles),
                        "Maximum number of files to read cannot be less than one.");
                }

                _maxReadFiles = value;
            }
        }
        
        public int MaxGenerateFiles
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxGenerateFiles),
                        "Maximum number of files to generate cannot be less than one.");
                }

                _maxGenerateFiles = value;
            }
        }
        
        public int MaxWriteFiles
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxWriteFiles),
                        "Maximum number of files to write cannot be less than one.");
                }

                _maxWriteFiles = value;
            }
        }

        public ITestGenerator Build()
        {
            return new NUnitTestGenerator(_maxReadFiles, _maxGenerateFiles, _maxWriteFiles);
        }
    }
}