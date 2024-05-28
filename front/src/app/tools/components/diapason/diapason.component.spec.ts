import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiapasonComponent } from './diapason.component';

describe('DiapasonComponent', () => {
  let component: DiapasonComponent;
  let fixture: ComponentFixture<DiapasonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DiapasonComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DiapasonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
