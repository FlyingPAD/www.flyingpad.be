import { FormatRatioPipe } from './format-ratio.pipe';

describe('FormatRatioPipe', () => {
  let pipe: FormatRatioPipe;

  beforeEach(() => {
    pipe = new FormatRatioPipe();
  });

  it('create an instance', () => {
    expect(pipe).toBeTruthy();
  });

  it('should return "16:9" for width 1920 and height 1080', () => {
    expect(pipe.transform(1920, 1080)).toBe('16 : 9');
  });

  it('should return "4:3" for width 800 and height 600', () => {
    expect(pipe.transform(800, 600)).toBe('4 : 3');
  });

  it('should return "1:1" for a square format', () => {
    expect(pipe.transform(500, 500)).toBe('1 : 1');
  });

  it('should return an empty string if width is zero', () => {
    expect(pipe.transform(0, 1080)).toBe('');
  });

  it('should return an empty string if height is zero', () => {
    expect(pipe.transform(1920, 0)).toBe('');
  });

  it('should return an empty string if both width and height are zero', () => {
    expect(pipe.transform(0, 0)).toBe('');
  });

  it('should return "3:2" for width 1500 and height 1000', () => {
    expect(pipe.transform(1500, 1000)).toBe('3 : 2');
  });

  it('should return "5:7" for width 500 and height 700', () => {
    expect(pipe.transform(500, 700)).toBe('5 : 7');
  });
});